using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HUDManagerRegistrationRequest : HUDManagerRequest
	{
		[Ordinal(1)] 
		[RED("isRegistering")] 
		public CBool IsRegistering
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<HUDActorType> Type
		{
			get => GetPropertyValue<CEnum<HUDActorType>>();
			set => SetPropertyValue<CEnum<HUDActorType>>(value);
		}

		public HUDManagerRegistrationRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
