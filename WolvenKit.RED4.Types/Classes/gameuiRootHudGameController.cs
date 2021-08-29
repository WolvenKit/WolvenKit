using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiRootHudGameController : gameuiWidgetGameController
	{
		private CArray<inkCompoundWidgetReference> _resolutionSensitiveRoots;

		[Ordinal(2)] 
		[RED("resolutionSensitiveRoots")] 
		public CArray<inkCompoundWidgetReference> ResolutionSensitiveRoots
		{
			get => GetProperty(ref _resolutionSensitiveRoots);
			set => SetProperty(ref _resolutionSensitiveRoots, value);
		}
	}
}
