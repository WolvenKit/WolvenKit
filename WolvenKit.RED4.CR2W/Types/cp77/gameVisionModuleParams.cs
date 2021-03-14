using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionModuleParams : CVariable
	{
		private CName _visionTag;
		private CArray<gameMeshDef> _meshComponents;

		[Ordinal(0)] 
		[RED("visionTag")] 
		public CName VisionTag
		{
			get
			{
				if (_visionTag == null)
				{
					_visionTag = (CName) CR2WTypeManager.Create("CName", "visionTag", cr2w, this);
				}
				return _visionTag;
			}
			set
			{
				if (_visionTag == value)
				{
					return;
				}
				_visionTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("meshComponents")] 
		public CArray<gameMeshDef> MeshComponents
		{
			get
			{
				if (_meshComponents == null)
				{
					_meshComponents = (CArray<gameMeshDef>) CR2WTypeManager.Create("array:gameMeshDef", "meshComponents", cr2w, this);
				}
				return _meshComponents;
			}
			set
			{
				if (_meshComponents == value)
				{
					return;
				}
				_meshComponents = value;
				PropertySet(this);
			}
		}

		public gameVisionModuleParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
