using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class characterCreationBodyMorphOptionSelectorButton : inkWidgetLogicController
	{
		private inkWidgetReference _overArrow;

		[Ordinal(1)] 
		[RED("overArrow")] 
		public inkWidgetReference OverArrow
		{
			get => GetProperty(ref _overArrow);
			set => SetProperty(ref _overArrow, value);
		}
	}
}
