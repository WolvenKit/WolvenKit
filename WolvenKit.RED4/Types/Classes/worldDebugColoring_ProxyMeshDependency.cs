using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_ProxyMeshDependency : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] 
		[RED("noneColor")] 
		public CColor NoneColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(1)] 
		[RED("hasProxyColor")] 
		public CColor HasProxyColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(2)] 
		[RED("discardColor")] 
		public CColor DiscardColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public worldDebugColoring_ProxyMeshDependency()
		{
			NoneColor = new CColor();
			HasProxyColor = new CColor();
			DiscardColor = new CColor();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
