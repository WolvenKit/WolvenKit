using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPopulactionControllerNodeDefinition : questBaseObjectNodeDefinition
	{
		[Ordinal(3)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questPopulactionControllerNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			Enable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
