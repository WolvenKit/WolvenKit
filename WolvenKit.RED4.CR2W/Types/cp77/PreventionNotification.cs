using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionNotification : GenericNotificationController
	{
		private CHandle<PreventionBountyViewData> _bounty_data;
		private inkTextWidgetReference _bountyTitleText;
		private inkTextWidgetReference _bountyAmountText;

		[Ordinal(12)] 
		[RED("bounty_data")] 
		public CHandle<PreventionBountyViewData> Bounty_data
		{
			get
			{
				if (_bounty_data == null)
				{
					_bounty_data = (CHandle<PreventionBountyViewData>) CR2WTypeManager.Create("handle:PreventionBountyViewData", "bounty_data", cr2w, this);
				}
				return _bounty_data;
			}
			set
			{
				if (_bounty_data == value)
				{
					return;
				}
				_bounty_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("bountyTitleText")] 
		public inkTextWidgetReference BountyTitleText
		{
			get
			{
				if (_bountyTitleText == null)
				{
					_bountyTitleText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "bountyTitleText", cr2w, this);
				}
				return _bountyTitleText;
			}
			set
			{
				if (_bountyTitleText == value)
				{
					return;
				}
				_bountyTitleText = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("bountyAmountText")] 
		public inkTextWidgetReference BountyAmountText
		{
			get
			{
				if (_bountyAmountText == null)
				{
					_bountyAmountText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "bountyAmountText", cr2w, this);
				}
				return _bountyAmountText;
			}
			set
			{
				if (_bountyAmountText == value)
				{
					return;
				}
				_bountyAmountText = value;
				PropertySet(this);
			}
		}

		public PreventionNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
