
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleVisualCustomizationPreviewSetup_Record
	{
		[RED("backgroundImage")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID BackgroundImage
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("leftLightMarginRight")]
		[REDProperty(IsIgnored = true)]
		public CFloat LeftLightMarginRight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("leftLightMarginTop")]
		[REDProperty(IsIgnored = true)]
		public CFloat LeftLightMarginTop
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lightsImage")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID LightsImage
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("previewLeftLight")]
		[REDProperty(IsIgnored = true)]
		public CBool PreviewLeftLight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("previewRightLight")]
		[REDProperty(IsIgnored = true)]
		public CBool PreviewRightLight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("primaryImage")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PrimaryImage
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("rightLightMarginRight")]
		[REDProperty(IsIgnored = true)]
		public CFloat RightLightMarginRight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rightLightMarginTop")]
		[REDProperty(IsIgnored = true)]
		public CFloat RightLightMarginTop
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("secondaryImage")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID SecondaryImage
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
