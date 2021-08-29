using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkCacheWidget : inkCompoundWidget
	{
		private Vector2 _innerScale;
		private CEnum<inkCacheMode> _mode;
		private CName _externalDynamicTexture;

		[Ordinal(23)] 
		[RED("innerScale")] 
		public Vector2 InnerScale
		{
			get => GetProperty(ref _innerScale);
			set => SetProperty(ref _innerScale, value);
		}

		[Ordinal(24)] 
		[RED("mode")] 
		public CEnum<inkCacheMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(25)] 
		[RED("externalDynamicTexture")] 
		public CName ExternalDynamicTexture
		{
			get => GetProperty(ref _externalDynamicTexture);
			set => SetProperty(ref _externalDynamicTexture, value);
		}
	}
}
