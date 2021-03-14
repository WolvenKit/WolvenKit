using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AITargetTrackerComponent : entIComponent
	{
		private CBool _triggersCombat;

		[Ordinal(3)] 
		[RED("TriggersCombat")] 
		public CBool TriggersCombat
		{
			get
			{
				if (_triggersCombat == null)
				{
					_triggersCombat = (CBool) CR2WTypeManager.Create("Bool", "TriggersCombat", cr2w, this);
				}
				return _triggersCombat;
			}
			set
			{
				if (_triggersCombat == value)
				{
					return;
				}
				_triggersCombat = value;
				PropertySet(this);
			}
		}

		public AITargetTrackerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
