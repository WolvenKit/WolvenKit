using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPhysicalTriggerAreaNode : worldNode
	{
		private CEnum<physicsSimulationType> _simulationType;
		private physicsTriggerShape _shape;
		private CHandle<physicsFilterData> _filterData;

		[Ordinal(4)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get => GetProperty(ref _simulationType);
			set => SetProperty(ref _simulationType, value);
		}

		[Ordinal(5)] 
		[RED("shape")] 
		public physicsTriggerShape Shape
		{
			get => GetProperty(ref _shape);
			set => SetProperty(ref _shape, value);
		}

		[Ordinal(6)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}

		public worldPhysicalTriggerAreaNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
