using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questProximityProgressBar_ConditionType : questIUIConditionType
	{
		private CEnum<questProximityProgressBarAction> _action;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<questProximityProgressBarAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CEnum<questProximityProgressBarAction>) CR2WTypeManager.Create("questProximityProgressBarAction", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		public questProximityProgressBar_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
