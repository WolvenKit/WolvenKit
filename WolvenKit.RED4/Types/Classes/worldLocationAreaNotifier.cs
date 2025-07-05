using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldLocationAreaNotifier : worldITriggerAreaNotifer
	{
		[Ordinal(3)] 
		[RED("districtID")] 
		public TweakDBID DistrictID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("sendNewLocationNotification")] 
		public CBool SendNewLocationNotification
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldLocationAreaNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;
			SendNewLocationNotification = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
