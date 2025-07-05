using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsSystemResource : CResource
	{
		[Ordinal(1)] 
		[RED("bodies")] 
		public CArray<CHandle<physicsSystemBody>> Bodies
		{
			get => GetPropertyValue<CArray<CHandle<physicsSystemBody>>>();
			set => SetPropertyValue<CArray<CHandle<physicsSystemBody>>>(value);
		}

		[Ordinal(2)] 
		[RED("joints")] 
		public CArray<CHandle<physicsSystemJoint>> Joints
		{
			get => GetPropertyValue<CArray<CHandle<physicsSystemJoint>>>();
			set => SetPropertyValue<CArray<CHandle<physicsSystemJoint>>>(value);
		}

		public physicsSystemResource()
		{
			Bodies = new();
			Joints = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
