using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsSystemResource : CResource
	{
		private CArray<CHandle<physicsSystemBody>> _bodies;
		private CArray<CHandle<physicsSystemJoint>> _joints;

		[Ordinal(1)] 
		[RED("bodies")] 
		public CArray<CHandle<physicsSystemBody>> Bodies
		{
			get => GetProperty(ref _bodies);
			set => SetProperty(ref _bodies, value);
		}

		[Ordinal(2)] 
		[RED("joints")] 
		public CArray<CHandle<physicsSystemJoint>> Joints
		{
			get => GetProperty(ref _joints);
			set => SetProperty(ref _joints, value);
		}

		public physicsSystemResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
