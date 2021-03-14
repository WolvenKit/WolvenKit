using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisableRPGRequirementsForDeviceActions : redEvent
	{
		private TweakDBID _action;
		private CBool _disable;

		[Ordinal(0)] 
		[RED("action")] 
		public TweakDBID Action
		{
			get
			{
				if (_action == null)
				{
					_action = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "action", cr2w, this);
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

		[Ordinal(1)] 
		[RED("disable")] 
		public CBool Disable
		{
			get
			{
				if (_disable == null)
				{
					_disable = (CBool) CR2WTypeManager.Create("Bool", "disable", cr2w, this);
				}
				return _disable;
			}
			set
			{
				if (_disable == value)
				{
					return;
				}
				_disable = value;
				PropertySet(this);
			}
		}

		public DisableRPGRequirementsForDeviceActions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
