using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NCPDJobDoneNotification : JournalNotification
	{
		private inkWidgetReference _nCPD_Reward;
		private inkTextWidgetReference _nCPD_XP_RewardText;
		private inkTextWidgetReference _nCPD_SC_RewardText;

		[Ordinal(16)] 
		[RED("NCPD_Reward")] 
		public inkWidgetReference NCPD_Reward
		{
			get => GetProperty(ref _nCPD_Reward);
			set => SetProperty(ref _nCPD_Reward, value);
		}

		[Ordinal(17)] 
		[RED("NCPD_XP_RewardText")] 
		public inkTextWidgetReference NCPD_XP_RewardText
		{
			get => GetProperty(ref _nCPD_XP_RewardText);
			set => SetProperty(ref _nCPD_XP_RewardText, value);
		}

		[Ordinal(18)] 
		[RED("NCPD_SC_RewardText")] 
		public inkTextWidgetReference NCPD_SC_RewardText
		{
			get => GetProperty(ref _nCPD_SC_RewardText);
			set => SetProperty(ref _nCPD_SC_RewardText, value);
		}

		public NCPDJobDoneNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
