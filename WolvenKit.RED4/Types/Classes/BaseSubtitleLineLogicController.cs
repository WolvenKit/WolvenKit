using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseSubtitleLineLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("subtitleWidget")] 
		public inkTextWidgetReference SubtitleWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("radioSubtitle")] 
		public inkTextWidgetReference RadioSubtitle
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(4)] 
		[RED("isKiroshiEnabled")] 
		public CBool IsKiroshiEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("c_tier1_duration")] 
		public CFloat C_tier1_duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("c_tier2_duration")] 
		public CFloat C_tier2_duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public BaseSubtitleLineLogicController()
		{
			SubtitleWidget = new inkTextWidgetReference();
			RadioSubtitle = new inkTextWidgetReference();
			C_tier1_duration = 0.500000F;
			C_tier2_duration = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
