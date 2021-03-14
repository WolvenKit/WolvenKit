using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class resResourceSnapshot : CResource
	{
		private CArray<raRef<CResource>> _resources;

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

		public resResourceSnapshot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
