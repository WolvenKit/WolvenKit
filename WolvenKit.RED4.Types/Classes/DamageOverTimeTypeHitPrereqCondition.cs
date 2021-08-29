using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DamageOverTimeTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		private CEnum<gamedataStatusEffectType> _dotType;

		[Ordinal(1)] 
		[RED("dotType")] 
		public CEnum<gamedataStatusEffectType> DotType
		{
			get => GetProperty(ref _dotType);
			set => SetProperty(ref _dotType, value);
		}
	}
}
