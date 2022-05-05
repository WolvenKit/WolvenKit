using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameAttachedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isGameplayRelevant")] 
		public CBool IsGameplayRelevant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("displayName")] 
		public CString DisplayName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("contentScale")] 
		public TweakDBID ContentScale
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public GameAttachedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
