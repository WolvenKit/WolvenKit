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
			get => GetProperty(ref _bounty_data);
			set => SetProperty(ref _bounty_data, value);
		}

		[Ordinal(13)] 
		[RED("bountyTitleText")] 
		public inkTextWidgetReference BountyTitleText
		{
			get => GetProperty(ref _bountyTitleText);
			set => SetProperty(ref _bountyTitleText, value);
		}

		[Ordinal(14)] 
		[RED("bountyAmountText")] 
		public inkTextWidgetReference BountyAmountText
		{
			get => GetProperty(ref _bountyAmountText);
			set => SetProperty(ref _bountyAmountText, value);
		}

		public PreventionNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
