using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NetRunnerListItem : inkWidgetLogicController
	{
		private inkWidgetReference _highlight;

		[Ordinal(1)] 
		[RED("highlight")] 
		public inkWidgetReference Highlight
		{
			get => GetProperty(ref _highlight);
			set => SetProperty(ref _highlight, value);
		}
	}
}
