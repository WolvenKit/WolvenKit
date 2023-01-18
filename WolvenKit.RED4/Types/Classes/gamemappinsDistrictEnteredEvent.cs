using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemappinsDistrictEnteredEvent : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("entered")] 
		public CBool Entered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("sendNewLocationNotification")] 
		public CBool SendNewLocationNotification
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("district")] 
		public TweakDBID District
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gamemappinsDistrictEnteredEvent()
		{
			Entered = true;
			SendNewLocationNotification = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
