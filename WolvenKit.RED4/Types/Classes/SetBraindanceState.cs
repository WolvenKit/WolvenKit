using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetBraindanceState : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("newState")] 
		public CBool NewState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetBraindanceState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
