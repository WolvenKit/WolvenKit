using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMinigameNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("start")] 
		public CBool Start
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("skipSummaryScreen")] 
		public CBool SkipSummaryScreen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("networkRef")] 
		public gameEntityReference NetworkRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public questMinigameNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			Start = true;
			NetworkRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
