using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkCacheWidget : inkCompoundWidget
	{
		[Ordinal(23)] 
		[RED("innerScale")] 
		public Vector2 InnerScale
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(24)] 
		[RED("mode")] 
		public CEnum<inkCacheMode> Mode
		{
			get => GetPropertyValue<CEnum<inkCacheMode>>();
			set => SetPropertyValue<CEnum<inkCacheMode>>(value);
		}

		[Ordinal(25)] 
		[RED("externalDynamicTexture")] 
		public CName ExternalDynamicTexture
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkCacheWidget()
		{
			InnerScale = new() { X = 1.000000F, Y = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
