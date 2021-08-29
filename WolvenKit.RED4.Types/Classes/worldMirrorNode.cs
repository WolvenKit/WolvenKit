using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldMirrorNode : worldMeshNode
	{
		private Vector3 _cullingBoxExtents;
		private Vector3 _cullingBoxOffset;

		[Ordinal(15)] 
		[RED("cullingBoxExtents")] 
		public Vector3 CullingBoxExtents
		{
			get => GetProperty(ref _cullingBoxExtents);
			set => SetProperty(ref _cullingBoxExtents, value);
		}

		[Ordinal(16)] 
		[RED("cullingBoxOffset")] 
		public Vector3 CullingBoxOffset
		{
			get => GetProperty(ref _cullingBoxOffset);
			set => SetProperty(ref _cullingBoxOffset, value);
		}
	}
}
