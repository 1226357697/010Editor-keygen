using System;
using System.Text;

namespace _010EditorKeygen
{
	internal static class Keygen
	{
		private static uint GetEncryStr(string str, uint num)
		{
			uint num2 = num << 4;
			num2 -= num;
			uint num3 = 0U;
			uint num4 = 0U;
			uint num5 = 0U;
			foreach (uint num6 in Keygen.UTF8.GetBytes(str))
			{
				num2 %= 256U;
				uint num7 = num6;
				if (num7 >= 97U && num7 <= 122U)
				{
					num7 -= 32U;
				}
				num3 = (Keygen.Data[(int)num7] + num3 ^ Keygen.Data[(int)(num7 + 13U & 255U)]) * Keygen.Data[(int)(num7 + 47U & 255U)] + Keygen.Data[(int)num4] + Keygen.Data[(int)num2] + Keygen.Data[(int)num5];
				num5 += 19U;
				num4 += 9U;
				num2 += 13U;
			}
			return num3;
		}

		private static bool CheckInput(string username, uint number)
		{
			if (number >= 1U && number <= 1000U)
			{
				byte[] bytes = Encoding.UTF8.GetBytes(username);
				if (bytes.Length != 0 && bytes.Length < 15)
				{
					return true;
				}
			}
			return false;
		}

		public static string MakeKey(string username, uint number)
		{
			if (!Keygen.CheckInput(username, number))
			{
				return string.Empty;
			}
			short[] array = new short[7];
			uint num = (number * 11U ^ 13345U) - 19760U ^ 30866U;
			uint encryStr = Keygen.GetEncryStr(username, number);
			array[1] = Convert.ToInt16(num / 256U % 256U);
			array[2] = Convert.ToInt16(num % 256U);
			array[3] = Convert.ToInt16(encryStr % 256U);
			array[4] = Convert.ToInt16(encryStr % 65536U / 256U);
			array[5] = Convert.ToInt16(encryStr / 65536U % 256U);
			array[6] = Convert.ToInt16(encryStr / 16777216U);
			short[] array2 = array;
			int num2 = 1;
			array2[num2] ^= array[6];
			short[] array3 = array;
			int num3 = 2;
			array3[num3] ^= array[4];
			array[0] = Convert.ToInt16((int)(array[5] ^ 224));
			string[] array4 = new string[7];
			for (int i = 0; i < 7; i++)
			{
				if (array[i] < 16)
				{
					array4[i] = string.Format("0{0}", Convert.ToString(array[i], 16));
				}
				else
				{
					array4[i] = string.Format("{0}", Convert.ToString(array[i], 16));
				}
			}
			return string.Format("{0}{1}-{2}9C-{3}{4}-{5}{6}", new object[]
			{
				array4[0],
				array4[1],
				array4[2],
				array4[3],
				array4[4],
				array4[5],
				array4[6]
			}).ToUpper();
		}

		private static readonly UTF8Encoding UTF8 = new UTF8Encoding(false);

		private static readonly uint[] Data = new uint[]
		{
			969622712U,
			594890599U,
			1593930257U,
			1052452058U,
			890701766U,
			1677293387U,
			394424968U,
			266815521U,
			1532978959U,
			1211194088U,
			2019260265U,
			729421127U,
			953225874U,
			1117854514U,
			892543556U,
			2000911200U,
			514538256U,
			1400963072U,
			486675118U,
			1862498216U,
			1136668818U,
			758909582U,
			1653935295U,
			821063674U,
			888606944U,
			687085563U,
			890056597U,
			1513495898U,
			365692427U,
			184357836U,
			677395407U,
			863045227U,
			818746596U,
			391985767U,
			1842768403U,
			758385145U,
			1478392706U,
			1985112985U,
			1552765320U,
			746944881U,
			368385984U,
			1758203153U,
			1240817244U,
			660489060U,
			756944316U,
			1290697955U,
			844453952U,
			288239112U,
			1769473626U,
			1922176006U,
			826636519U,
			391520695U,
			1081548223U,
			1069693142U,
			1244729994U,
			766313326U,
			1101031894U,
			624951698U,
			14501479U,
			1794907983U,
			1460682958U,
			1660839647U,
			1104890686U,
			897721119U,
			1442187162U,
			480708164U,
			454443986U,
			1064446153U,
			1595150448U,
			1041527979U,
			1145775470U,
			1399869657U,
			255985995U,
			802693350U,
			2005610078U,
			1897360642U,
			2146073193U,
			1538606632U,
			431647857U,
			964049561U,
			395138253U,
			19164808U,
			856904574U,
			730737943U,
			708645054U,
			1506870658U,
			933323739U,
			819349658U,
			1780571206U,
			236747382U,
			533160167U,
			2042104933U,
			670325172U,
			2040165158U,
			1354372994U,
			705785180U,
			1669754395U,
			1066536508U,
			1426207888U,
			1437950089U,
			741941201U,
			796931522U,
			1694313338U,
			1290302874U,
			1367672048U,
			2039808424U,
			1062939821U,
			954597728U,
			1668694488U,
			859122242U,
			1369582617U,
			140269649U,
			53024683U,
			729221831U,
			816609203U,
			736893191U,
			55706320U,
			262747091U,
			1629838835U,
			581764799U,
			1488480625U,
			1607077349U,
			1879925846U,
			1453945819U,
			1521965565U,
			856558562U,
			1530662365U,
			1230847072U,
			1404918182U,
			1281256849U,
			1238970765U,
			272453753U,
			1640907491U,
			2127893021U,
			350314733U,
			556617458U,
			654390256U,
			1648581270U,
			531062411U,
			1862873022U,
			1241517385U,
			1471028336U,
			5121143U,
			1444839026U,
			1183580211U,
			1573659650U,
			2018540230U,
			1487873223U,
			234237236U,
			898254600U,
			1023090193U,
			728843548U,
			2007454357U,
			1451820833U,
			267351539U,
			302982385U,
			26807015U,
			865879122U,
			664886158U,
			195503981U,
			1625037691U,
			1330347906U,
			1742434311U,
			1330272217U,
			1645368040U,
			542321916U,
			1782121222U,
			411042851U,
			435386250U,
			1176704752U,
			1454246199U,
			1136813916U,
			1707755005U,
			224415730U,
			201138891U,
			989750331U,
			1006010278U,
			1147286905U,
			406860280U,
			840388503U,
			1282017578U,
			1605698145U,
			23396724U,
			862145265U,
			1898780916U,
			1855549801U,
			1571519230U,
			2083204840U,
			1859876276U,
			1602449334U,
			1009413590U,
			690816450U,
			86131931U,
			345661263U,
			1565025600U,
			857544170U,
			1329948960U,
			1211787679U,
			994381573U,
			991984748U,
			1956475134U,
			1098146294U,
			1655714289U,
			659576699U,
			689116467U,
			1485584392U,
			451884118U,
			255590636U,
			2108114754U,
			1266252396U,
			1589326471U,
			2019907768U,
			15552498U,
			1651075358U,
			614606175U,
			1656823678U,
			797605325U,
			1681594366U,
			2005080248U,
			624648446U,
			884695971U,
			1526931791U,
			1595240948U,
			439447199U,
			2060396292U,
			680093752U,
			409028215U,
			469068267U,
			195583689U,
			1791650630U,
			507724330U,
			1364025102U,
			1094582668U,
			813049577U,
			32316922U,
			1240756058U,
			1176200235U,
			2104494066U,
			325396055U,
			1796606917U,
			1709197385U,
			525495836U,
			1510101430U,
			735526761U,
			767523533U,
			1374043776U,
			1559389967U,
			567085571U,
			1560216161U,
			867042846U,
			1001796703U,
			1568754293U,
			628841972U,
			173812827U,
			379868455U,
			384973125U
		};
	}
}
