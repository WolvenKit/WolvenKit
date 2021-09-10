using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckCurrentWoundedState : AIStatusEffectCondition
	{
		[Ordinal(0)] 
		[RED("woundedTypeToCompare")] 
		public CEnum<EWoundedBodyPart> WoundedTypeToCompare
		{
			get => GetPropertyValue<CEnum<EWoundedBodyPart>>();
			set => SetPropertyValue<CEnum<EWoundedBodyPart>>(value);
		}
	}
}
