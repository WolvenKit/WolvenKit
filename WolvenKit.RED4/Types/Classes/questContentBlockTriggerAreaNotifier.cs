using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questContentBlockTriggerAreaNotifier : worldITriggerAreaNotifer
	{
		[Ordinal(3)] 
		[RED("resetTokenSpawnTimer")] 
		public CBool ResetTokenSpawnTimer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questContentBlockTriggerAreaNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;
			ResetTokenSpawnTimer = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
