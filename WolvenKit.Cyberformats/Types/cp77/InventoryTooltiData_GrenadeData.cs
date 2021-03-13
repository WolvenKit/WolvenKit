using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryTooltiData_GrenadeData : IScriptable
	{
		[Ordinal(0)] [RED("type")] public CEnum<GrenadeDamageType> Type { get; set; }
		[Ordinal(1)] [RED("range")] public CFloat Range { get; set; }
		[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(3)] [RED("delay")] public CFloat Delay { get; set; }
		[Ordinal(4)] [RED("damagePerTick")] public CFloat DamagePerTick { get; set; }
		[Ordinal(5)] [RED("damageType")] public CEnum<gamedataStatType> DamageType { get; set; }
		[Ordinal(6)] [RED("detonationTimer")] public CFloat DetonationTimer { get; set; }
		[Ordinal(7)] [RED("deliveryMethod")] public CEnum<gamedataGrenadeDeliveryMethodType> DeliveryMethod { get; set; }
		[Ordinal(8)] [RED("totalDamage")] public CFloat TotalDamage { get; set; }

		public InventoryTooltiData_GrenadeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
