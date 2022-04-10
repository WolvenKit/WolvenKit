using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LocomotionTransition : DefaultTransition
	{
		[Ordinal(0)] 
		[RED("ownerRecordId")] 
		public TweakDBID OwnerRecordId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("statModifierGroupId")] 
		public CUInt64 StatModifierGroupId
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(2)] 
		[RED("statModifierTDBNameDefault")] 
		public CString StatModifierTDBNameDefault
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public LocomotionTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
