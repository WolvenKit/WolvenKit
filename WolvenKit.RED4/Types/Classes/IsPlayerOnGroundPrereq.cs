using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IsPlayerOnGroundPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public IsPlayerOnGroundPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
