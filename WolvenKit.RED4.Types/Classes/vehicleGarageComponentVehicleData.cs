using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleGarageComponentVehicleData : RedBaseClass
	{
		private TweakDBID _spawnRecordID;
		private entEntityID _entityID;
		private NodeRef _vehicleNameNodeRef;

		[Ordinal(0)] 
		[RED("spawnRecordID")] 
		public TweakDBID SpawnRecordID
		{
			get => GetProperty(ref _spawnRecordID);
			set => SetProperty(ref _spawnRecordID, value);
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetProperty(ref _entityID);
			set => SetProperty(ref _entityID, value);
		}

		[Ordinal(2)] 
		[RED("vehicleNameNodeRef")] 
		public NodeRef VehicleNameNodeRef
		{
			get => GetProperty(ref _vehicleNameNodeRef);
			set => SetProperty(ref _vehicleNameNodeRef, value);
		}
	}
}
