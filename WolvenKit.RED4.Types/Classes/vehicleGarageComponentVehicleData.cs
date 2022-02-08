using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleGarageComponentVehicleData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("spawnRecordID")] 
		public TweakDBID SpawnRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("vehicleNameNodeRef")] 
		public NodeRef VehicleNameNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public vehicleGarageComponentVehicleData()
		{
			EntityID = new();
		}
	}
}
