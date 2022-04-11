using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldPhysicalTriggerAreaNode : worldNode
	{
		[Ordinal(4)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get => GetPropertyValue<CEnum<physicsSimulationType>>();
			set => SetPropertyValue<CEnum<physicsSimulationType>>(value);
		}

		[Ordinal(5)] 
		[RED("shape")] 
		public physicsTriggerShape Shape
		{
			get => GetPropertyValue<physicsTriggerShape>();
			set => SetPropertyValue<physicsTriggerShape>(value);
		}

		[Ordinal(6)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetPropertyValue<CHandle<physicsFilterData>>();
			set => SetPropertyValue<CHandle<physicsFilterData>>(value);
		}

		public worldPhysicalTriggerAreaNode()
		{
			SimulationType = Enums.physicsSimulationType.Dynamic;
			Shape = new() { ShapeSize = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F }, ShapeLocalPose = new() { Position = new(), Orientation = new() { R = 1.000000F } } };
		}
	}
}
