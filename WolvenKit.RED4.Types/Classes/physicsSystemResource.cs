using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsSystemResource : CResource
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
	}
}
