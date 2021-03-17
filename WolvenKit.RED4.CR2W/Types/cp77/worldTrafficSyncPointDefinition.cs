using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficSyncPointDefinition : CVariable
	{
		private CArray<NodeRef> _laneRefs;
		private CArray<CFloat> _lanePositions;
		private CFloat _length;

		[Ordinal(0)] 
		[RED("laneRefs")] 
		public CArray<NodeRef> LaneRefs
		{
			get => GetProperty(ref _laneRefs);
			set => SetProperty(ref _laneRefs, value);
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

		public worldTrafficSyncPointDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
