using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckCurrentWoundedState : AIStatusEffectCondition
	{
		private CEnum<EWoundedBodyPart> _woundedTypeToCompare;

		[Ordinal(0)] 
		[RED("woundedTypeToCompare")] 
		public CEnum<EWoundedBodyPart> WoundedTypeToCompare
		{
			get => GetProperty(ref _woundedTypeToCompare);
			set => SetProperty(ref _woundedTypeToCompare, value);
		}
	}
}
