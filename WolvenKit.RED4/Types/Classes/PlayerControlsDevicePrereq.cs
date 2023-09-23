using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerControlsDevicePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("inverse")] 
		public CBool Inverse
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PlayerControlsDevicePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
