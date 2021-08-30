using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CustomAnimationsGameController : gameuiWidgetGameController
	{
		private CHandle<WidgetAnimationManager> _customAnimations;
		private CArray<CName> _onSpawnAnimations;
		private CName _defaultLibraryItemName;
		private CEnum<inkEAnchor> _defaultLibraryItemAnchor;
		private CWeakHandle<inkWidget> _spawnedLibrararyItem;
		private CName _curentLibraryItemName;
		private CEnum<inkEAnchor> _currentLibraryItemAnchor;
		private CWeakHandle<inkCompoundWidget> _root;
		private CBool _isInitialized;
		private entEntityID _ownerID;

		[Ordinal(2)] 
		[RED("customAnimations")] 
		public CHandle<WidgetAnimationManager> CustomAnimations
		{
			get => GetProperty(ref _customAnimations);
			set => SetProperty(ref _customAnimations, value);
		}

		[Ordinal(3)] 
		[RED("onSpawnAnimations")] 
		public CArray<CName> OnSpawnAnimations
		{
			get => GetProperty(ref _onSpawnAnimations);
			set => SetProperty(ref _onSpawnAnimations, value);
		}

		[Ordinal(4)] 
		[RED("defaultLibraryItemName")] 
		public CName DefaultLibraryItemName
		{
			get => GetProperty(ref _defaultLibraryItemName);
			set => SetProperty(ref _defaultLibraryItemName, value);
		}

		[Ordinal(5)] 
		[RED("defaultLibraryItemAnchor")] 
		public CEnum<inkEAnchor> DefaultLibraryItemAnchor
		{
			get => GetProperty(ref _defaultLibraryItemAnchor);
			set => SetProperty(ref _defaultLibraryItemAnchor, value);
		}

		[Ordinal(6)] 
		[RED("spawnedLibrararyItem")] 
		public CWeakHandle<inkWidget> SpawnedLibrararyItem
		{
			get => GetProperty(ref _spawnedLibrararyItem);
			set => SetProperty(ref _spawnedLibrararyItem, value);
		}

		[Ordinal(7)] 
		[RED("curentLibraryItemName")] 
		public CName CurentLibraryItemName
		{
			get => GetProperty(ref _curentLibraryItemName);
			set => SetProperty(ref _curentLibraryItemName, value);
		}

		[Ordinal(8)] 
		[RED("currentLibraryItemAnchor")] 
		public CEnum<inkEAnchor> CurrentLibraryItemAnchor
		{
			get => GetProperty(ref _currentLibraryItemAnchor);
			set => SetProperty(ref _currentLibraryItemAnchor, value);
		}

		[Ordinal(9)] 
		[RED("root")] 
		public CWeakHandle<inkCompoundWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(10)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetProperty(ref _isInitialized);
			set => SetProperty(ref _isInitialized, value);
		}

		[Ordinal(11)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		public CustomAnimationsGameController()
		{
			_defaultLibraryItemAnchor = new() { Value = Enums.inkEAnchor.Fill };
		}
	}
}
