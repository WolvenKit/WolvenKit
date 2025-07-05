using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkAnimatedAdvertController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("loopType")] 
		public CEnum<inkanimLoopType> LoopType
		{
			get => GetPropertyValue<CEnum<inkanimLoopType>>();
			set => SetPropertyValue<CEnum<inkanimLoopType>>(value);
		}

		public inkAnimatedAdvertController()
		{
			LoopType = Enums.inkanimLoopType.Cycle;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
