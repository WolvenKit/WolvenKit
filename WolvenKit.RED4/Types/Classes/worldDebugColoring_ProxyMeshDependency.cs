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
			NoneColor = new CColor { Red = 127, Green = 127, Blue = 127, Alpha = 255 };
			HasProxyColor = new CColor { Green = 255, Alpha = 255 };
			DiscardColor = new CColor { Red = 255, Blue = 255, Alpha = 255 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
