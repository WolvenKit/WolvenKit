using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleComponentsEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("componentsData")] 
		public CArray<SComponentOperationData> ComponentsData
		{
			get => GetPropertyValue<CArray<SComponentOperationData>>();
			set => SetPropertyValue<CArray<SComponentOperationData>>(value);
		}

		public ToggleComponentsEvent()
		{
			ComponentsData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
