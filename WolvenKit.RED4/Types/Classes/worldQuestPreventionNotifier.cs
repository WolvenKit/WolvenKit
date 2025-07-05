using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldQuestPreventionNotifier : worldITriggerAreaNotifer
	{
		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<worldQuestPreventionNotifierType> Type
		{
			get => GetPropertyValue<CEnum<worldQuestPreventionNotifierType>>();
			set => SetPropertyValue<CEnum<worldQuestPreventionNotifierType>>(value);
		}

		[Ordinal(4)] 
		[RED("activation")] 
		public CEnum<worldQuestPreventionNotifierActivation> Activation
		{
			get => GetPropertyValue<CEnum<worldQuestPreventionNotifierActivation>>();
			set => SetPropertyValue<CEnum<worldQuestPreventionNotifierActivation>>(value);
		}

		public worldQuestPreventionNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
