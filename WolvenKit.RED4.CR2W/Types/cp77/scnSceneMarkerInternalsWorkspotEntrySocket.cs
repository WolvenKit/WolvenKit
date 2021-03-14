using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneMarkerInternalsWorkspotEntrySocket : CVariable
	{
		private CName _name;
		private Transform _transform;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("transform")] 
		public Transform Transform
		{
			get
			{
				if (_transform == null)
				{
					_transform = (Transform) CR2WTypeManager.Create("Transform", "transform", cr2w, this);
				}
				return _transform;
			}
			set
			{
				if (_transform == value)
				{
					return;
				}
				_transform = value;
				PropertySet(this);
			}
		}

		public scnSceneMarkerInternalsWorkspotEntrySocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
