using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace RF5_CatchAlwaysSucceeds
{
	/*
	[HarmonyPatch(typeof(Calc.CalcHandCuffs), nameof(Calc.CalcHandCuffs.OnHitMonster))]
	public class CalcHandCuffsPatch
	{
		static bool Prefix(out bool isRestraint, ref bool __result)
		{
			isRestraint = true;
			__result = true;
			return false;
		}
	}
	*/

	[HarmonyPatch(typeof(Calc.CalcHandCuffs), nameof(Calc.CalcHandCuffs.LotteryOrderMonster))]
	public class CalcHandCuffsPatch2
	{
		static bool Prefix(MonsterControllerBase monster, ref bool __result)
		{
			__result = true;
			return false;
		}
	}

	[HarmonyPatch(typeof(Calc.CalcHandCuffs), nameof(Calc.CalcHandCuffs.LotteryWantedMonster))]
	public class CalcHandCuffsPatch3
	{
		static bool Prefix(ref bool __result)
		{
			__result = true;
			return false;
		}
	}

	[HarmonyPatch(typeof(Calc.CalcHandCuffs), nameof(Calc.CalcHandCuffs.LotteryInPartyMonster))]
	public class CalcHandCuffsPatch4
	{
		static bool Prefix(ref bool __result)
		{
			__result = true;
			return false;
		}
	}
}
