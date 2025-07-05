using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseSubtitleLineLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(2)] 
		[RED("isKiroshiEnabled")] 
		public CBool IsKiroshiEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("c_tier1_duration")] 
		public CFloat C_tier1_duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("c_tier2_duration")] 
		public CFloat C_tier2_duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public BaseSubtitleLineLogicController()
		{
			C_tier1_duration = 0.500000F;
			C_tier2_duration = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
