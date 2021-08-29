using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficLanePlayerGPSInfo : RedBaseClass
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
	}
}
