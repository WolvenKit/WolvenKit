using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTutorialOverlayData : CVariable
	{
		private redResourceReferenceScriptToken _widgetLibraryResource;
		private CName _itemName;

		[Ordinal(0)] 
		[RED("widgetLibraryResource")] 
		public redResourceReferenceScriptToken WidgetLibraryResource
		{
			get => GetProperty(ref _widgetLibraryResource);
			set => SetProperty(ref _widgetLibraryResource, value);
		}

		[Ordinal(1)] 
		[RED("itemName")] 
		public CName ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}

		public gameTutorialOverlayData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
