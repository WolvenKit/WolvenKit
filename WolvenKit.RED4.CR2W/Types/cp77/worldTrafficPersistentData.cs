using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficPersistentData : CVariable
	{
		private CArray<worldTrafficLanePersistent> _lanes;
		private CArray<CArray<CUInt16>> _neighborGroups;

		[Ordinal(0)] 
		[RED("lanes")] 
		public CArray<worldTrafficLanePersistent> Lanes
		{
			get => GetProperty(ref _lanes);
			set => SetProperty(ref _lanes, value);
		}

		[Ordinal(1)] 
		[RED("neighborGroups")] 
		public CArray<CArray<CUInt16>> NeighborGroups
		{
			get => GetProperty(ref _neighborGroups);
			set => SetProperty(ref _neighborGroups, value);
		}

		public worldTrafficPersistentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
