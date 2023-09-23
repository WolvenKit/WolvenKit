using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerUnauthorized : ActionBool
	{
		[Ordinal(38)] 
		[RED("isLiftDoor")] 
		public CBool IsLiftDoor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PlayerUnauthorized()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
