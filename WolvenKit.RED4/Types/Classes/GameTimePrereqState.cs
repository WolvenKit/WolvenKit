using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameTimePrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("listener")] 
		public CUInt32 Listener
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("repeated")] 
		public CBool Repeated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public GameTimePrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
