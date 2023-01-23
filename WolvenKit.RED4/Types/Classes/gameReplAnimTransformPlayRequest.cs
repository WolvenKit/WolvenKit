using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameReplAnimTransformPlayRequest : gameReplAnimTransformRequestBase
	{
		[Ordinal(1)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("timesToPlay")] 
		public CInt32 TimesToPlay
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameReplAnimTransformPlayRequest()
		{
			TimeScale = 1.000000F;
			TimesToPlay = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
