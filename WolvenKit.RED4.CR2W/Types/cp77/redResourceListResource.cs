using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class redResourceListResource : CResource
	{
		private CArray<raRef<CResource>> _resources;
		private CArray<CString> _descriptions;

		[Ordinal(1)] 
		[RED("resources")] 
		public CArray<raRef<CResource>> Resources
		{
			get
			{
				if (_resources == null)
				{
					_resources = (CArray<raRef<CResource>>) CR2WTypeManager.Create("array:raRef:CResource", "resources", cr2w, this);
				}
				return _resources;
			}
			set
			{
				if (_resources == value)
				{
					return;
				}
				_resources = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("descriptions")] 
		public CArray<CString> Descriptions
		{
			get
			{
				if (_descriptions == null)
				{
					_descriptions = (CArray<CString>) CR2WTypeManager.Create("array:String", "descriptions", cr2w, this);
				}
				return _descriptions;
			}
			set
			{
				if (_descriptions == value)
				{
					return;
				}
				_descriptions = value;
				PropertySet(this);
			}
		}

		public redResourceListResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
