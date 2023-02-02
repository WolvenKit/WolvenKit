using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameaudioeventsNotifyFootstepMaterialContextChanged : redEvent
	{
		[Ordinal(0)] 
		[RED("footwareType")] 
		public CName FootwareType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("surfaceFlavourName")] 
		public CName SurfaceFlavourName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameaudioeventsNotifyFootstepMaterialContextChanged()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
