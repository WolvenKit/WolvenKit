using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questStopRazerAnimation_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questStopRazerAnimation_NodeTypeParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
