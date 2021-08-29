using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiQuestMappinController : gameuiInteractionMappinController
	{
		private CBool _nameplateVisible;
		private inkTextWidgetReference _distanceText;
		private inkTextWidgetReference _displayName;

		[Ordinal(11)] 
		[RED("nameplateVisible")] 
		public CBool NameplateVisible
		{
			get => GetProperty(ref _nameplateVisible);
			set => SetProperty(ref _nameplateVisible, value);
		}

		[Ordinal(12)] 
		[RED("distanceText")] 
		public inkTextWidgetReference DistanceText
		{
			get => GetProperty(ref _distanceText);
			set => SetProperty(ref _distanceText, value);
		}

		[Ordinal(13)] 
		[RED("displayName")] 
		public inkTextWidgetReference DisplayName
		{
			get => GetProperty(ref _displayName);
			set => SetProperty(ref _displayName, value);
		}
	}
}
