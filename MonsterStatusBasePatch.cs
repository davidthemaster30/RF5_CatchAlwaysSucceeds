using HarmonyLib;

namespace RF5_CatchAlwaysSucceeds;

[HarmonyPatch(typeof(MonsterStatusBase), nameof(MonsterStatusBase.TakeRestraintDamage))]
public class MonsterStatusBasePatch
{
	static void Prefix(ref float damage)
	{
		damage = 9999999.0f;
	}
}
