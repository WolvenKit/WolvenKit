using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentFillMeshInfo : entdismembermentMeshInfo
	{
		private CEnum<entdismembermentPlacementE> _placement;
		private CEnum<entdismembermentSimulationTypeE> _simulation;
		private entdismembermentDangleInfo _dangle;

		[Ordinal(10)] 
		[RED("Placement")] 
		public CEnum<entdismembermentPlacementE> Placement
		{
			get
			{
				if (_placement == null)
				{
					_placement = (CEnum<entdismembermentPlacementE>) CR2WTypeManager.Create("entdismembermentPlacementE", "Placement", cr2w, this);
				}
				return _placement;
			}
			set
			{
				if (_placement == value)
				{
					return;
				}
				_placement = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("Simulation")] 
		public CEnum<entdismembermentSimulationTypeE> Simulation
		{
			get
			{
				if (_simulation == null)
				{
					_simulation = (CEnum<entdismembermentSimulationTypeE>) CR2WTypeManager.Create("entdismembermentSimulationTypeE", "Simulation", cr2w, this);
				}
				return _simulation;
			}
			set
			{
				if (_simulation == value)
				{
					return;
				}
				_simulation = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("Dangle")] 
		public entdismembermentDangleInfo Dangle
		{
			get
			{
				if (_dangle == null)
				{
					_dangle = (entdismembermentDangleInfo) CR2WTypeManager.Create("entdismembermentDangleInfo", "Dangle", cr2w, this);
				}
				return _dangle;
			}
			set
			{
				if (_dangle == value)
				{
					return;
				}
				_dangle = value;
				PropertySet(this);
			}
		}

		public entdismembermentFillMeshInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
