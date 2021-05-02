using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLanePlayerGPSInfo : CVariable
	{
		private CUInt16 _subGraphId;
		private CUInt16 _stronglyConnectedComponentId;

		[Ordinal(0)] 
		[RED("subGraphId")] 
		public CUInt16 SubGraphId
		{
			get => GetProperty(ref _subGraphId);
			set => SetProperty(ref _subGraphId, value);
		}

		[Ordinal(1)] 
		[RED("stronglyConnectedComponentId")] 
		public CUInt16 StronglyConnectedComponentId
		{
			get => GetProperty(ref _stronglyConnectedComponentId);
			set => SetProperty(ref _stronglyConnectedComponentId, value);
		}

		public worldTrafficLanePlayerGPSInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
