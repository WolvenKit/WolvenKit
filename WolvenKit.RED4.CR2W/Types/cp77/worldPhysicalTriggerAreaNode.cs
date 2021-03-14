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
			get
			{
				if (_simulationType == null)
				{
					_simulationType = (CEnum<physicsSimulationType>) CR2WTypeManager.Create("physicsSimulationType", "simulationType", cr2w, this);
				}
				return _simulationType;
			}
			set
			{
				if (_simulationType == value)
				{
					return;
				}
				_simulationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("shape")] 
		public physicsTriggerShape Shape
		{
			get
			{
				if (_shape == null)
				{
					_shape = (physicsTriggerShape) CR2WTypeManager.Create("physicsTriggerShape", "shape", cr2w, this);
				}
				return _shape;
			}
			set
			{
				if (_shape == value)
				{
					return;
				}
				_shape = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get
			{
				if (_filterData == null)
				{
					_filterData = (CHandle<physicsFilterData>) CR2WTypeManager.Create("handle:physicsFilterData", "filterData", cr2w, this);
				}
				return _filterData;
			}
			set
			{
				if (_filterData == value)
				{
					return;
				}
				_filterData = value;
				PropertySet(this);
			}
		}

		public worldPhysicalTriggerAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
