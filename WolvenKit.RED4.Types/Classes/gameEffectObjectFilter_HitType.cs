using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectFilter_HitType : gameEffectObjectSingleFilter
	{
		private CEnum<gameEffectObjectFilter_HitTypeAction> _action;
		private CEnum<gameEffectHitDataType> _hitType;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<gameEffectObjectFilter_HitTypeAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(1)] 
		[RED("hitType")] 
		public CEnum<gameEffectHitDataType> HitType
		{
			get => GetProperty(ref _hitType);
			set => SetProperty(ref _hitType, value);
		}
	}
}
