using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldMirrorNode : worldMeshNode
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

		public worldMirrorNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
