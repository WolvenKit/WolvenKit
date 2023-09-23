using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HUDManagerAssociationRequest : HUDManagerRequest
	{
		[Ordinal(1)] 
		[RED("associatedID")] 
		public entEntityID AssociatedID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("isRegistering")] 
		public CBool IsRegistering
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HUDManagerAssociationRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
