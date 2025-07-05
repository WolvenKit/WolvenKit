using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectFilter_HitType : gameEffectObjectSingleFilter
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<gameEffectObjectFilter_HitTypeAction> Action
		{
			get => GetPropertyValue<CEnum<gameEffectObjectFilter_HitTypeAction>>();
			set => SetPropertyValue<CEnum<gameEffectObjectFilter_HitTypeAction>>(value);
		}

		[Ordinal(1)] 
		[RED("hitType")] 
		public CEnum<gameEffectHitDataType> HitType
		{
			get => GetPropertyValue<CEnum<gameEffectHitDataType>>();
			set => SetPropertyValue<CEnum<gameEffectHitDataType>>(value);
		}

		public gameEffectObjectFilter_HitType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
