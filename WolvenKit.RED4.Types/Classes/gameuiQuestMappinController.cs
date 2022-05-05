using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiQuestMappinController : gameuiInteractionMappinController
	{
		[Ordinal(11)] 
		[RED("nameplateVisible")] 
		public CBool NameplateVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("distanceText")] 
		public inkTextWidgetReference DistanceText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("displayName")] 
		public inkTextWidgetReference DisplayName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public gameuiQuestMappinController()
		{
			DistanceText = new();
			DisplayName = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
