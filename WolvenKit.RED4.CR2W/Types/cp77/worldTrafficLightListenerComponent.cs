using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLightListenerComponent : entIComponent
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

		public worldTrafficLightListenerComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
