using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficLightListenerComponent : entIComponent
	{
		private NodeRef _intersectionRef;
		private CUInt32 _groupIdx;

		[Ordinal(3)] 
		[RED("intersectionRef")] 
		public NodeRef IntersectionRef
		{
			get => GetProperty(ref _intersectionRef);
			set => SetProperty(ref _intersectionRef, value);
		}

		[Ordinal(4)] 
		[RED("groupIdx")] 
		public CUInt32 GroupIdx
		{
			get => GetProperty(ref _groupIdx);
			set => SetProperty(ref _groupIdx, value);
		}
	}
}
