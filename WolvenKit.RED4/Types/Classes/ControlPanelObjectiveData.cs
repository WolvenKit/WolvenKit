
namespace WolvenKit.RED4.Types
{
	public partial class ControlPanelObjectiveData : GemplayObjectiveData
	{
		public ControlPanelObjectiveData()
		{
			QuestUniqueId = "TECHNICAL_GRID";
			QuestTitle = "TECHNICAL GRID";
			ObjectiveDescription = "Gain access to control panel in order to manipulate devices";
			UniqueIdPrefix = "controlPanel";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
