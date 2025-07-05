using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehiclePanzerBootupUIQuestEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<panzerBootupUI> Mode
		{
			get => GetPropertyValue<CEnum<panzerBootupUI>>();
			set => SetPropertyValue<CEnum<panzerBootupUI>>(value);
		}

		public VehiclePanzerBootupUIQuestEvent()
		{
			Mode = Enums.panzerBootupUI.Loop;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
