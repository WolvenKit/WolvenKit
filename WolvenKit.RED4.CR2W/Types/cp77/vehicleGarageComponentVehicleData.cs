using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleGarageComponentVehicleData : CVariable
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

		public vehicleGarageComponentVehicleData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
