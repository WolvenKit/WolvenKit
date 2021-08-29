using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleUIAnchorButton : inkWidgetLogicController
	{
		private CEnum<inkEAnchor> _anchorLocation;

		[Ordinal(1)] 
		[RED("anchorLocation")] 
		public CEnum<inkEAnchor> AnchorLocation
		{
			get => GetProperty(ref _anchorLocation);
			set => SetProperty(ref _anchorLocation, value);
		}
	}
}
