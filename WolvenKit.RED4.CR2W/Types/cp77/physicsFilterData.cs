using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsFilterData : ISerializable
	{
		private physicsSimulationFilter _simulationFilter;
		private physicsQueryFilter _queryFilter;
		private CName _preset;
		private CHandle<physicsCustomFilterData> _customFilterData;

		[Ordinal(0)] 
		[RED("simulationFilter")] 
		public physicsSimulationFilter SimulationFilter
		{
			get
			{
				if (_simulationFilter == null)
				{
					_simulationFilter = (physicsSimulationFilter) CR2WTypeManager.Create("physicsSimulationFilter", "simulationFilter", cr2w, this);
				}
				return _simulationFilter;
			}
			set
			{
				if (_simulationFilter == value)
				{
					return;
				}
				_simulationFilter = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("queryFilter")] 
		public physicsQueryFilter QueryFilter
		{
			get
			{
				if (_queryFilter == null)
				{
					_queryFilter = (physicsQueryFilter) CR2WTypeManager.Create("physicsQueryFilter", "queryFilter", cr2w, this);
				}
				return _queryFilter;
			}
			set
			{
				if (_queryFilter == value)
				{
					return;
				}
				_queryFilter = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("preset")] 
		public CName Preset
		{
			get
			{
				if (_preset == null)
				{
					_preset = (CName) CR2WTypeManager.Create("CName", "preset", cr2w, this);
				}
				return _preset;
			}
			set
			{
				if (_preset == value)
				{
					return;
				}
				_preset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("customFilterData")] 
		public CHandle<physicsCustomFilterData> CustomFilterData
		{
			get
			{
				if (_customFilterData == null)
				{
					_customFilterData = (CHandle<physicsCustomFilterData>) CR2WTypeManager.Create("handle:physicsCustomFilterData", "customFilterData", cr2w, this);
				}
				return _customFilterData;
			}
			set
			{
				if (_customFilterData == value)
				{
					return;
				}
				_customFilterData = value;
				PropertySet(this);
			}
		}

		public physicsFilterData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
