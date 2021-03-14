using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNavigationDeniedAreaNode : worldAreaShapeNode
	{
		private CEnum<worldEDeniedAreaFlags> _flags;

		[Ordinal(6)] 
		[RED("flags")] 
		public CEnum<worldEDeniedAreaFlags> Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CEnum<worldEDeniedAreaFlags>) CR2WTypeManager.Create("worldEDeniedAreaFlags", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
				PropertySet(this);
			}
		}

		public worldNavigationDeniedAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
