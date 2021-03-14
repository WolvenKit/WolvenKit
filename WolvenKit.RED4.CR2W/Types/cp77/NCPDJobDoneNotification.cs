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
			get
			{
				if (_nCPD_Reward == null)
				{
					_nCPD_Reward = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "NCPD_Reward", cr2w, this);
				}
				return _nCPD_Reward;
			}
			set
			{
				if (_nCPD_Reward == value)
				{
					return;
				}
				_nCPD_Reward = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("NCPD_XP_RewardText")] 
		public inkTextWidgetReference NCPD_XP_RewardText
		{
			get
			{
				if (_nCPD_XP_RewardText == null)
				{
					_nCPD_XP_RewardText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "NCPD_XP_RewardText", cr2w, this);
				}
				return _nCPD_XP_RewardText;
			}
			set
			{
				if (_nCPD_XP_RewardText == value)
				{
					return;
				}
				_nCPD_XP_RewardText = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("NCPD_SC_RewardText")] 
		public inkTextWidgetReference NCPD_SC_RewardText
		{
			get
			{
				if (_nCPD_SC_RewardText == null)
				{
					_nCPD_SC_RewardText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "NCPD_SC_RewardText", cr2w, this);
				}
				return _nCPD_SC_RewardText;
			}
			set
			{
				if (_nCPD_SC_RewardText == value)
				{
					return;
				}
				_nCPD_SC_RewardText = value;
				PropertySet(this);
			}
		}

		public NCPDJobDoneNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
