using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomAnimationsHudGameController : gameuiHUDGameController
	{
		private CHandle<WidgetAnimationManager> _customAnimations;
		private CArray<CName> _onSpawnAnimations;
		private CName _defaultLibraryItemName;
		private CEnum<inkEAnchor> _defaultLibraryItemAnchor;
		private wCHandle<inkWidget> _spawnedLibrararyItem;
		private CName _curentLibraryItemName;
		private CEnum<inkEAnchor> _currentLibraryItemAnchor;
		private wCHandle<inkCompoundWidget> _root;
		private CBool _isInitialized;
		private entEntityID _ownerID;

		[Ordinal(9)] 
		[RED("customAnimations")] 
		public CHandle<WidgetAnimationManager> CustomAnimations
		{
			get => GetProperty(ref _customAnimations);
			set => SetProperty(ref _customAnimations, value);
		}

		[Ordinal(10)] 
		[RED("onSpawnAnimations")] 
		public CArray<CName> OnSpawnAnimations
		{
			get => GetProperty(ref _onSpawnAnimations);
			set => SetProperty(ref _onSpawnAnimations, value);
		}

		[Ordinal(11)] 
		[RED("defaultLibraryItemName")] 
		public CName DefaultLibraryItemName
		{
			get => GetProperty(ref _defaultLibraryItemName);
			set => SetProperty(ref _defaultLibraryItemName, value);
		}

		[Ordinal(12)] 
		[RED("defaultLibraryItemAnchor")] 
		public CEnum<inkEAnchor> DefaultLibraryItemAnchor
		{
			get => GetProperty(ref _defaultLibraryItemAnchor);
			set => SetProperty(ref _defaultLibraryItemAnchor, value);
		}

		[Ordinal(13)] 
		[RED("spawnedLibrararyItem")] 
		public wCHandle<inkWidget> SpawnedLibrararyItem
		{
			get => GetProperty(ref _spawnedLibrararyItem);
			set => SetProperty(ref _spawnedLibrararyItem, value);
		}

		[Ordinal(14)] 
		[RED("curentLibraryItemName")] 
		public CName CurentLibraryItemName
		{
			get => GetProperty(ref _curentLibraryItemName);
			set => SetProperty(ref _curentLibraryItemName, value);
		}

		[Ordinal(15)] 
		[RED("currentLibraryItemAnchor")] 
		public CEnum<inkEAnchor> CurrentLibraryItemAnchor
		{
			get => GetProperty(ref _currentLibraryItemAnchor);
			set => SetProperty(ref _currentLibraryItemAnchor, value);
		}

		[Ordinal(16)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(17)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetProperty(ref _isInitialized);
			set => SetProperty(ref _isInitialized, value);
		}

		[Ordinal(18)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		public CustomAnimationsHudGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
