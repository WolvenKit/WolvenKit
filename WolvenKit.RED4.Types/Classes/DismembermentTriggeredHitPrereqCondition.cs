using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DismembermentTriggeredHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("dotType")] 
		public CEnum<gamedataStatusEffectType> DotType
		{
			get => GetPropertyValue<CEnum<gamedataStatusEffectType>>();
			set => SetPropertyValue<CEnum<gamedataStatusEffectType>>(value);
		}
	}
}
