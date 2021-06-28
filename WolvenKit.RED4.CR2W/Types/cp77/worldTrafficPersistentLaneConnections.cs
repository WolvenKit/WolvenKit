using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficPersistentLaneConnections : CVariable
	{
		private CArray<worldTrafficConnectivityOutLane> _outlanes;
		private CArray<worldTrafficConnectivityInLane> _inLanes;

		[Ordinal(0)] 
		[RED("outlanes")] 
		public CArray<worldTrafficConnectivityOutLane> Outlanes
		{
			get => GetProperty(ref _outlanes);
			set => SetProperty(ref _outlanes, value);
		}

		[Ordinal(1)] 
		[RED("inLanes")] 
		public CArray<worldTrafficConnectivityInLane> InLanes
		{
			get => GetProperty(ref _inLanes);
			set => SetProperty(ref _inLanes, value);
		}

		public worldTrafficPersistentLaneConnections(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
