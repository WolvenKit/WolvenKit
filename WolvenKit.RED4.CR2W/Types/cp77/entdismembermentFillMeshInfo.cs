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
			get => GetProperty(ref _placement);
			set => SetProperty(ref _placement, value);
		}

		[Ordinal(11)] 
		[RED("Simulation")] 
		public CEnum<entdismembermentSimulationTypeE> Simulation
		{
			get => GetProperty(ref _simulation);
			set => SetProperty(ref _simulation, value);
		}

		[Ordinal(12)] 
		[RED("Dangle")] 
		public entdismembermentDangleInfo Dangle
		{
			get => GetProperty(ref _dangle);
			set => SetProperty(ref _dangle, value);
		}

		public entdismembermentFillMeshInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
