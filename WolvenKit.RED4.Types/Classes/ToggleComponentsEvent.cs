using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ToggleComponentsEvent : redEvent
	{
		private CArray<SComponentOperationData> _componentsData;

		[Ordinal(0)] 
		[RED("componentsData")] 
		public CArray<SComponentOperationData> ComponentsData
		{
			get => GetProperty(ref _componentsData);
			set => SetProperty(ref _componentsData, value);
		}
	}
}
