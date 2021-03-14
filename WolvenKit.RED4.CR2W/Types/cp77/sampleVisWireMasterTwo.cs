using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleVisWireMasterTwo : gameObject
	{
		private CArray<NodeRef> _dependableEntities;

		[Ordinal(40)] 
		[RED("dependableEntities")] 
		public CArray<NodeRef> DependableEntities
		{
			get
			{
				if (_dependableEntities == null)
				{
					_dependableEntities = (CArray<NodeRef>) CR2WTypeManager.Create("array:NodeRef", "dependableEntities", cr2w, this);
				}
				return _dependableEntities;
			}
			set
			{
				if (_dependableEntities == value)
				{
					return;
				}
				_dependableEntities = value;
				PropertySet(this);
			}
		}

		public sampleVisWireMasterTwo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
