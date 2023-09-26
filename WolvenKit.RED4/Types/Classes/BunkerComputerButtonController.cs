using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BunkerComputerButtonController : LinkController
	{
		[Ordinal(17)] 
		[RED("usePopupDefault")] 
		public CBool UsePopupDefault
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BunkerComputerButtonController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
