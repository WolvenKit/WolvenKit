using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NCPDJobDoneNotification : JournalNotification
	{
		[Ordinal(16)] 
		[RED("NCPD_Reward")] 
		public inkWidgetReference NCPD_Reward
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("NCPD_XP_RewardText")] 
		public inkTextWidgetReference NCPD_XP_RewardText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("NCPD_SC_RewardText")] 
		public inkTextWidgetReference NCPD_SC_RewardText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public NCPDJobDoneNotification()
		{
			NCPD_Reward = new();
			NCPD_XP_RewardText = new();
			NCPD_SC_RewardText = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
