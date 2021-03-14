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
			get
			{
				if (_cullingBoxExtents == null)
				{
					_cullingBoxExtents = (Vector3) CR2WTypeManager.Create("Vector3", "cullingBoxExtents", cr2w, this);
				}
				return _cullingBoxExtents;
			}
			set
			{
				if (_cullingBoxExtents == value)
				{
					return;
				}
				_cullingBoxExtents = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("cullingBoxOffset")] 
		public Vector3 CullingBoxOffset
		{
			get
			{
				if (_cullingBoxOffset == null)
				{
					_cullingBoxOffset = (Vector3) CR2WTypeManager.Create("Vector3", "cullingBoxOffset", cr2w, this);
				}
				return _cullingBoxOffset;
			}
			set
			{
				if (_cullingBoxOffset == value)
				{
					return;
				}
				_cullingBoxOffset = value;
				PropertySet(this);
			}
		}

		public worldMirrorNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
