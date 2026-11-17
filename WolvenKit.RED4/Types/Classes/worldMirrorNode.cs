using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldMirrorNode : worldMeshNode
	{
		[Ordinal(16)] 
		[RED("cullingBoxExtents")] 
		public Vector3 CullingBoxExtents
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(17)] 
		[RED("cullingBoxOffset")] 
		public Vector3 CullingBoxOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public worldMirrorNode()
		{
			CullingBoxExtents = new Vector3 { X = 20.000000F, Y = 20.000000F, Z = 20.000000F };
			CullingBoxOffset = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
