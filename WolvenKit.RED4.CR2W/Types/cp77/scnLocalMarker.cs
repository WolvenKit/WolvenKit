using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnLocalMarker : CVariable
	{
		private Transform _transformLS;
		private CName _name;

		[Ordinal(0)] 
		[RED("transformLS")] 
		public Transform TransformLS
		{
			get
			{
				if (_transformLS == null)
				{
					_transformLS = (Transform) CR2WTypeManager.Create("Transform", "transformLS", cr2w, this);
				}
				return _transformLS;
			}
			set
			{
				if (_transformLS == value)
				{
					return;
				}
				_transformLS = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public scnLocalMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
