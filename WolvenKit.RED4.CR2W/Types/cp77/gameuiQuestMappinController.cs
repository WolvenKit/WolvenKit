using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiQuestMappinController : gameuiInteractionMappinController
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

		public gameuiQuestMappinController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
