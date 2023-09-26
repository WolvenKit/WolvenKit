using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerDoesntHaveQuickhackPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("quickhackID")] 
		public TweakDBID QuickhackID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public PlayerDoesntHaveQuickhackPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
