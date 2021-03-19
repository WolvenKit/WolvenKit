using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSpawnDespawnEntityParams : CVariable
	{
		private CName _dynamicEntityUniqueName;
		private CName _spawnMarker;
		private CEnum<scnMarkerType> _spawnMarkerType;
		private NodeRef _spawnMarkerNodeRef;
		private Transform _spawnOffset;
		private scnPerformerId _itemOwnerId;
		private TweakDBID _specRecordId;
		private CName _appearance;
		private CBool _spawnOnStart;
		private CBool _isEnabled;
		private CBool _validateSpawnPostion;
		private CBool _alwaysSpawned;
		private CBool _keepAlive;
		private CBool _findInWorld;
		private CBool _forceMaxVisibility;
		private CBool _prefetchAppearance;

		[Ordinal(0)] 
		[RED("dynamicEntityUniqueName")] 
		public CName DynamicEntityUniqueName
		{
			get => GetProperty(ref _dynamicEntityUniqueName);
			set => SetProperty(ref _dynamicEntityUniqueName, value);
		}

		[Ordinal(1)] 
		[RED("spawnMarker")] 
		public CName SpawnMarker
		{
			get => GetProperty(ref _spawnMarker);
			set => SetProperty(ref _spawnMarker, value);
		}

		[Ordinal(2)] 
		[RED("spawnMarkerType")] 
		public CEnum<scnMarkerType> SpawnMarkerType
		{
			get => GetProperty(ref _spawnMarkerType);
			set => SetProperty(ref _spawnMarkerType, value);
		}

		[Ordinal(3)] 
		[RED("spawnMarkerNodeRef")] 
		public NodeRef SpawnMarkerNodeRef
		{
			get => GetProperty(ref _spawnMarkerNodeRef);
			set => SetProperty(ref _spawnMarkerNodeRef, value);
		}

		[Ordinal(4)] 
		[RED("spawnOffset")] 
		public Transform SpawnOffset
		{
			get => GetProperty(ref _spawnOffset);
			set => SetProperty(ref _spawnOffset, value);
		}

		[Ordinal(5)] 
		[RED("itemOwnerId")] 
		public scnPerformerId ItemOwnerId
		{
			get => GetProperty(ref _itemOwnerId);
			set => SetProperty(ref _itemOwnerId, value);
		}

		[Ordinal(6)] 
		[RED("specRecordId")] 
		public TweakDBID SpecRecordId
		{
			get => GetProperty(ref _specRecordId);
			set => SetProperty(ref _specRecordId, value);
		}

		[Ordinal(7)] 
		[RED("appearance")] 
		public CName Appearance
		{
			get => GetProperty(ref _appearance);
			set => SetProperty(ref _appearance, value);
		}

		[Ordinal(8)] 
		[RED("spawnOnStart")] 
		public CBool SpawnOnStart
		{
			get => GetProperty(ref _spawnOnStart);
			set => SetProperty(ref _spawnOnStart, value);
		}

		[Ordinal(9)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(10)] 
		[RED("validateSpawnPostion")] 
		public CBool ValidateSpawnPostion
		{
			get => GetProperty(ref _validateSpawnPostion);
			set => SetProperty(ref _validateSpawnPostion, value);
		}

		[Ordinal(11)] 
		[RED("alwaysSpawned")] 
		public CBool AlwaysSpawned
		{
			get => GetProperty(ref _alwaysSpawned);
			set => SetProperty(ref _alwaysSpawned, value);
		}

		[Ordinal(12)] 
		[RED("keepAlive")] 
		public CBool KeepAlive
		{
			get => GetProperty(ref _keepAlive);
			set => SetProperty(ref _keepAlive, value);
		}

		[Ordinal(13)] 
		[RED("findInWorld")] 
		public CBool FindInWorld
		{
			get => GetProperty(ref _findInWorld);
			set => SetProperty(ref _findInWorld, value);
		}

		[Ordinal(14)] 
		[RED("forceMaxVisibility")] 
		public CBool ForceMaxVisibility
		{
			get => GetProperty(ref _forceMaxVisibility);
			set => SetProperty(ref _forceMaxVisibility, value);
		}

		[Ordinal(15)] 
		[RED("prefetchAppearance")] 
		public CBool PrefetchAppearance
		{
			get => GetProperty(ref _prefetchAppearance);
			set => SetProperty(ref _prefetchAppearance, value);
		}

		public scnSpawnDespawnEntityParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
