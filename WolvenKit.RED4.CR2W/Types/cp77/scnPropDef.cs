using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPropDef : CVariable
	{
		private scnPropId _propId;
		private CString _propName;
		private TweakDBID _specPropRecordId;
		private CArray<scnRidAnimSetSRRefId> _animSets;
		private CArray<scnCinematicAnimSetSRRefId> _cinematicAnimSets;
		private CArray<scnDynamicAnimSetSRRefId> _dynamicAnimSets;
		private CEnum<scnEntityAcquisitionPlan> _entityAcquisitionPlan;
		private scnFindEntityInEntityParams _findEntityInEntityParams;
		private scnSpawnDespawnEntityParams _spawnDespawnParams;
		private scnSpawnSetParams _spawnSetParams;
		private scnCommunityParams _communityParams;
		private scnSpawnerParams _spawnerParams;
		private scnFindEntityInNodeParams _findEntityInNodeParams;
		private scnFindEntityInWorldParams _findEntityInWorldParams;

		[Ordinal(0)] 
		[RED("propId")] 
		public scnPropId PropId
		{
			get => GetProperty(ref _propId);
			set => SetProperty(ref _propId, value);
		}

		[Ordinal(1)] 
		[RED("propName")] 
		public CString PropName
		{
			get => GetProperty(ref _propName);
			set => SetProperty(ref _propName, value);
		}

		[Ordinal(2)] 
		[RED("specPropRecordId")] 
		public TweakDBID SpecPropRecordId
		{
			get => GetProperty(ref _specPropRecordId);
			set => SetProperty(ref _specPropRecordId, value);
		}

		[Ordinal(3)] 
		[RED("animSets")] 
		public CArray<scnRidAnimSetSRRefId> AnimSets
		{
			get => GetProperty(ref _animSets);
			set => SetProperty(ref _animSets, value);
		}

		[Ordinal(4)] 
		[RED("cinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRefId> CinematicAnimSets
		{
			get => GetProperty(ref _cinematicAnimSets);
			set => SetProperty(ref _cinematicAnimSets, value);
		}

		[Ordinal(5)] 
		[RED("dynamicAnimSets")] 
		public CArray<scnDynamicAnimSetSRRefId> DynamicAnimSets
		{
			get => GetProperty(ref _dynamicAnimSets);
			set => SetProperty(ref _dynamicAnimSets, value);
		}

		[Ordinal(6)] 
		[RED("entityAcquisitionPlan")] 
		public CEnum<scnEntityAcquisitionPlan> EntityAcquisitionPlan
		{
			get => GetProperty(ref _entityAcquisitionPlan);
			set => SetProperty(ref _entityAcquisitionPlan, value);
		}

		[Ordinal(7)] 
		[RED("findEntityInEntityParams")] 
		public scnFindEntityInEntityParams FindEntityInEntityParams
		{
			get => GetProperty(ref _findEntityInEntityParams);
			set => SetProperty(ref _findEntityInEntityParams, value);
		}

		[Ordinal(8)] 
		[RED("spawnDespawnParams")] 
		public scnSpawnDespawnEntityParams SpawnDespawnParams
		{
			get => GetProperty(ref _spawnDespawnParams);
			set => SetProperty(ref _spawnDespawnParams, value);
		}

		[Ordinal(9)] 
		[RED("spawnSetParams")] 
		public scnSpawnSetParams SpawnSetParams
		{
			get => GetProperty(ref _spawnSetParams);
			set => SetProperty(ref _spawnSetParams, value);
		}

		[Ordinal(10)] 
		[RED("communityParams")] 
		public scnCommunityParams CommunityParams
		{
			get => GetProperty(ref _communityParams);
			set => SetProperty(ref _communityParams, value);
		}

		[Ordinal(11)] 
		[RED("spawnerParams")] 
		public scnSpawnerParams SpawnerParams
		{
			get => GetProperty(ref _spawnerParams);
			set => SetProperty(ref _spawnerParams, value);
		}

		[Ordinal(12)] 
		[RED("findEntityInNodeParams")] 
		public scnFindEntityInNodeParams FindEntityInNodeParams
		{
			get => GetProperty(ref _findEntityInNodeParams);
			set => SetProperty(ref _findEntityInNodeParams, value);
		}

		[Ordinal(13)] 
		[RED("findEntityInWorldParams")] 
		public scnFindEntityInWorldParams FindEntityInWorldParams
		{
			get => GetProperty(ref _findEntityInWorldParams);
			set => SetProperty(ref _findEntityInWorldParams, value);
		}

		public scnPropDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
