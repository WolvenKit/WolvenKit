using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ButtonHints : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _horizontalHolder;

		[Ordinal(1)] 
		[RED("horizontalHolder")] 
		public inkCompoundWidgetReference HorizontalHolder
		{
			get => GetProperty(ref _horizontalHolder);
			set => SetProperty(ref _horizontalHolder, value);
		}
	}
}
