using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICombatRelatedCommand : AICommand
	{
		private CBool _immediately;

		[Ordinal(4)] 
		[RED("immediately")] 
		public CBool Immediately
		{
			get
			{
				if (_immediately == null)
				{
					_immediately = (CBool) CR2WTypeManager.Create("Bool", "immediately", cr2w, this);
				}
				return _immediately;
			}
			set
			{
				if (_immediately == value)
				{
					return;
				}
				_immediately = value;
				PropertySet(this);
			}
		}

		public AICombatRelatedCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
