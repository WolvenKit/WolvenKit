using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficSyncPointCompiled : CVariable
	{
		private CArray<worldTrafficLaneUID> _lanes;
		private CArray<CFloat> _lanePositions;
		private CFloat _length;

		[Ordinal(0)] 
		[RED("lanes")] 
		public CArray<worldTrafficLaneUID> Lanes
		{
			get => GetProperty(ref _lanes);
			set => SetProperty(ref _lanes, value);
		}

		[Ordinal(1)] 
		[RED("lanePositions")] 
		public CArray<CFloat> LanePositions
		{
			get => GetProperty(ref _lanePositions);
			set => SetProperty(ref _lanePositions, value);
		}

		[Ordinal(2)] 
		[RED("length")] 
		public CFloat Length
		{
			get => GetProperty(ref _length);
			set => SetProperty(ref _length, value);
		}

		public worldTrafficSyncPointCompiled(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
