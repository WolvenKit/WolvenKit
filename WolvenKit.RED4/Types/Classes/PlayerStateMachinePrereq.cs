using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerStateMachinePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("previousState")] 
		public CBool PreviousState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isInState")] 
		public CBool IsInState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("skipWhenApplied")] 
		public CBool SkipWhenApplied
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("valueToListen")] 
		public CInt32 ValueToListen
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public PlayerStateMachinePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
