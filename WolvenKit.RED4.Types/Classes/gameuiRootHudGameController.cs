using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiRootHudGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("resolutionSensitiveRoots")] 
		public CArray<inkCompoundWidgetReference> ResolutionSensitiveRoots
		{
			get => GetPropertyValue<CArray<inkCompoundWidgetReference>>();
			set => SetPropertyValue<CArray<inkCompoundWidgetReference>>(value);
		}

		public gameuiRootHudGameController()
		{
			ResolutionSensitiveRoots = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
