using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitDamageOverTimePrereq : GenericHitPrereq
	{
		[Ordinal(5)] 
		[RED("dotType")] 
		public CEnum<gamedataStatusEffectType> DotType
		{
			get => GetPropertyValue<CEnum<gamedataStatusEffectType>>();
			set => SetPropertyValue<CEnum<gamedataStatusEffectType>>(value);
		}

		public HitDamageOverTimePrereq()
		{
			IsSync = true;
		}
	}
}
