using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnPropDef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("propId")] 
		public scnPropId PropId
		{
			get => GetPropertyValue<scnPropId>();
			set => SetPropertyValue<scnPropId>(value);
		}

		[Ordinal(1)] 
		[RED("propName")] 
		public CString PropName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("specPropRecordId")] 
		public TweakDBID SpecPropRecordId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("animSets")] 
		public CArray<scnRidAnimSetSRRefId> AnimSets
		{
			get => GetPropertyValue<CArray<scnRidAnimSetSRRefId>>();
			set => SetPropertyValue<CArray<scnRidAnimSetSRRefId>>(value);
		}

		[Ordinal(4)] 
		[RED("cinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRefId> CinematicAnimSets
		{
			get => GetPropertyValue<CArray<scnCinematicAnimSetSRRefId>>();
			set => SetPropertyValue<CArray<scnCinematicAnimSetSRRefId>>(value);
		}

		[Ordinal(5)] 
		[RED("dynamicAnimSets")] 
		public CArray<scnDynamicAnimSetSRRefId> DynamicAnimSets
		{
			get => GetPropertyValue<CArray<scnDynamicAnimSetSRRefId>>();
			set => SetPropertyValue<CArray<scnDynamicAnimSetSRRefId>>(value);
		}

		[Ordinal(6)] 
		[RED("entityAcquisitionPlan")] 
		public CEnum<scnEntityAcquisitionPlan> EntityAcquisitionPlan
		{
			get => GetPropertyValue<CEnum<scnEntityAcquisitionPlan>>();
			set => SetPropertyValue<CEnum<scnEntityAcquisitionPlan>>(value);
		}

		[Ordinal(7)] 
		[RED("findEntityInEntityParams")] 
		public scnFindEntityInEntityParams FindEntityInEntityParams
		{
			get => GetPropertyValue<scnFindEntityInEntityParams>();
			set => SetPropertyValue<scnFindEntityInEntityParams>(value);
		}

		[Ordinal(8)] 
		[RED("spawnDespawnParams")] 
		public scnSpawnDespawnEntityParams SpawnDespawnParams
		{
			get => GetPropertyValue<scnSpawnDespawnEntityParams>();
			set => SetPropertyValue<scnSpawnDespawnEntityParams>(value);
		}

		[Ordinal(9)] 
		[RED("spawnSetParams")] 
		public scnSpawnSetParams SpawnSetParams
		{
			get => GetPropertyValue<scnSpawnSetParams>();
			set => SetPropertyValue<scnSpawnSetParams>(value);
		}

		[Ordinal(10)] 
		[RED("communityParams")] 
		public scnCommunityParams CommunityParams
		{
			get => GetPropertyValue<scnCommunityParams>();
			set => SetPropertyValue<scnCommunityParams>(value);
		}

		[Ordinal(11)] 
		[RED("spawnerParams")] 
		public scnSpawnerParams SpawnerParams
		{
			get => GetPropertyValue<scnSpawnerParams>();
			set => SetPropertyValue<scnSpawnerParams>(value);
		}

		[Ordinal(12)] 
		[RED("findEntityInNodeParams")] 
		public scnFindEntityInNodeParams FindEntityInNodeParams
		{
			get => GetPropertyValue<scnFindEntityInNodeParams>();
			set => SetPropertyValue<scnFindEntityInNodeParams>(value);
		}

		[Ordinal(13)] 
		[RED("findEntityInWorldParams")] 
		public scnFindEntityInWorldParams FindEntityInWorldParams
		{
			get => GetPropertyValue<scnFindEntityInWorldParams>();
			set => SetPropertyValue<scnFindEntityInWorldParams>(value);
		}

		public scnPropDef()
		{
			PropId = new scnPropId { Id = uint.MaxValue };
			AnimSets = new();
			CinematicAnimSets = new();
			DynamicAnimSets = new();
			FindEntityInEntityParams = new scnFindEntityInEntityParams { ActorId = new scnActorId { Id = uint.MaxValue }, PerformerId = new scnPerformerId { Id = 4294967040 }, OwnershipTransferOptions = new scnPropOwnershipTransferOptions { DettachFromSlot = true, RemoveFromInventory = true } };
			SpawnDespawnParams = new scnSpawnDespawnEntityParams { SpawnOffset = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } }, ItemOwnerId = new scnPerformerId { Id = 4294967040 }, SpawnOnStart = true, IsEnabled = true, ValidateSpawnPostion = true };
			SpawnSetParams = new scnSpawnSetParams();
			CommunityParams = new scnCommunityParams();
			SpawnerParams = new scnSpawnerParams();
			FindEntityInNodeParams = new scnFindEntityInNodeParams();
			FindEntityInWorldParams = new scnFindEntityInWorldParams { ActorRef = new gameEntityReference { Names = new() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
