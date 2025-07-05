using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSpawnDespawnEntityParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("dynamicEntityUniqueName")] 
		public CName DynamicEntityUniqueName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("spawnMarker")] 
		public CName SpawnMarker
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("spawnMarkerType")] 
		public CEnum<scnMarkerType> SpawnMarkerType
		{
			get => GetPropertyValue<CEnum<scnMarkerType>>();
			set => SetPropertyValue<CEnum<scnMarkerType>>(value);
		}

		[Ordinal(3)] 
		[RED("spawnMarkerNodeRef")] 
		public NodeRef SpawnMarkerNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(4)] 
		[RED("spawnOffset")] 
		public Transform SpawnOffset
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(5)] 
		[RED("itemOwnerId")] 
		public scnPerformerId ItemOwnerId
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(6)] 
		[RED("specRecordId")] 
		public TweakDBID SpecRecordId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(7)] 
		[RED("appearance")] 
		public CName Appearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("spawnOnStart")] 
		public CBool SpawnOnStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("validateSpawnPostion")] 
		public CBool ValidateSpawnPostion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("alwaysSpawned")] 
		public CBool AlwaysSpawned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("keepAlive")] 
		public CBool KeepAlive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("findInWorld")] 
		public CBool FindInWorld
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("forceMaxVisibility")] 
		public CBool ForceMaxVisibility
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("prefetchAppearance")] 
		public CBool PrefetchAppearance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnSpawnDespawnEntityParams()
		{
			SpawnOffset = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };
			ItemOwnerId = new scnPerformerId { Id = 4294967040 };
			SpawnOnStart = true;
			IsEnabled = true;
			ValidateSpawnPostion = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
