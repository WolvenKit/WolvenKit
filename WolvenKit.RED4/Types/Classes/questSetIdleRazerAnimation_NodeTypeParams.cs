using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetIdleRazerAnimation_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("use")] 
		public CBool Use
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questSetIdleRazerAnimation_NodeTypeParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
