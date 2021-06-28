using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkListController : inkWidgetLogicController
	{
		private CName _itemLibraryID;
		private CBool _cycledNavigation;
		private CBool _beginToggled;
		private inkListControllerCallback _itemSelected;
		private inkListControllerCallback _itemActivated;

		[Ordinal(1)] 
		[RED("itemLibraryID")] 
		public CName ItemLibraryID
		{
			get => GetProperty(ref _itemLibraryID);
			set => SetProperty(ref _itemLibraryID, value);
		}

		[Ordinal(2)] 
		[RED("cycledNavigation")] 
		public CBool CycledNavigation
		{
			get => GetProperty(ref _cycledNavigation);
			set => SetProperty(ref _cycledNavigation, value);
		}

		[Ordinal(3)] 
		[RED("beginToggled")] 
		public CBool BeginToggled
		{
			get => GetProperty(ref _beginToggled);
			set => SetProperty(ref _beginToggled, value);
		}

		[Ordinal(4)] 
		[RED("ItemSelected")] 
		public inkListControllerCallback ItemSelected
		{
			get => GetProperty(ref _itemSelected);
			set => SetProperty(ref _itemSelected, value);
		}

		[Ordinal(5)] 
		[RED("ItemActivated")] 
		public inkListControllerCallback ItemActivated
		{
			get => GetProperty(ref _itemActivated);
			set => SetProperty(ref _itemActivated, value);
		}

		public inkListController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
