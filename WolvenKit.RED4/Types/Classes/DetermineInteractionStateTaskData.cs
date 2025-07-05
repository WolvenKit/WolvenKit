using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DetermineInteractionStateTaskData : gameScriptTaskData
	{
		[Ordinal(0)] 
		[RED("context")] 
		public gameGetActionsContext Context
		{
			get => GetPropertyValue<gameGetActionsContext>();
			set => SetPropertyValue<gameGetActionsContext>(value);
		}

		public DetermineInteractionStateTaskData()
		{
			Context = new gameGetActionsContext { RequestorID = new entEntityID(), ActionPrereqs = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
