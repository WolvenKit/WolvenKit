using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCutControlNodeDefinition : questDisableableNodeDefinition
	{
		private CBool _permanent;

		[Ordinal(2)] 
		[RED("permanent")] 
		public CBool Permanent
		{
			get
			{
				if (_permanent == null)
				{
					_permanent = (CBool) CR2WTypeManager.Create("Bool", "permanent", cr2w, this);
				}
				return _permanent;
			}
			set
			{
				if (_permanent == value)
				{
					return;
				}
				_permanent = value;
				PropertySet(this);
			}
		}

		public questCutControlNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
