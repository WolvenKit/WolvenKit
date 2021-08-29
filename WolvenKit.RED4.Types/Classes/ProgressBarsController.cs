using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ProgressBarsController : inkWidgetLogicController
	{
		private inkWidgetReference _mask;

		[Ordinal(1)] 
		[RED("mask")] 
		public inkWidgetReference Mask
		{
			get => GetProperty(ref _mask);
			set => SetProperty(ref _mask, value);
		}
	}
}
