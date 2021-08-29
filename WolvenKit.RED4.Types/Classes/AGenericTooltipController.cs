using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AGenericTooltipController : inkWidgetLogicController
	{
		private CWeakHandle<inkCompoundWidget> _root;

		[Ordinal(1)] 
		[RED("Root")] 
		public CWeakHandle<inkCompoundWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}
	}
}
