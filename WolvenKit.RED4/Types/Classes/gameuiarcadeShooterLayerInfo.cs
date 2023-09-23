using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeShooterLayerInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("referenceWidget")] 
		public inkWidgetReference ReferenceWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(1)] 
		[RED("planeRelativeValue")] 
		public Vector2 PlaneRelativeValue
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(2)] 
		[RED("layerName")] 
		public CName LayerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiarcadeShooterLayerInfo()
		{
			ReferenceWidget = new inkWidgetReference();
			PlaneRelativeValue = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
