using HarmonyLib;

namespace RF5_CatchAlwaysSucceeds;

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
