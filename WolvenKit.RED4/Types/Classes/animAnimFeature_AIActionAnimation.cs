using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_AIActionAnimation : animAnimFeature_AIAction
	{
		[Ordinal(4)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimFeature_AIActionAnimation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
