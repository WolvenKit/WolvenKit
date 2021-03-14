using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SuppressSecuritySystemStateChange : redEvent
	{
		private CBool _forceSecuritySystemIntoStrictQuestControl;

		[Ordinal(0)] 
		[RED("forceSecuritySystemIntoStrictQuestControl")] 
		public CBool ForceSecuritySystemIntoStrictQuestControl
		{
			get
			{
				if (_forceSecuritySystemIntoStrictQuestControl == null)
				{
					_forceSecuritySystemIntoStrictQuestControl = (CBool) CR2WTypeManager.Create("Bool", "forceSecuritySystemIntoStrictQuestControl", cr2w, this);
				}
				return _forceSecuritySystemIntoStrictQuestControl;
			}
			set
			{
				if (_forceSecuritySystemIntoStrictQuestControl == value)
				{
					return;
				}
				_forceSecuritySystemIntoStrictQuestControl = value;
				PropertySet(this);
			}
		}

		public SuppressSecuritySystemStateChange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
