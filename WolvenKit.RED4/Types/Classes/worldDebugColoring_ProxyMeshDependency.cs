using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_ProxyMeshDependency : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] 
		[RED("autoColor")] 
		public CColor AutoColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(1)] 
		[RED("discardColor")] 
		public CColor DiscardColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public worldDebugColoring_ProxyMeshDependency()
		{
			AutoColor = new();
			DiscardColor = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
