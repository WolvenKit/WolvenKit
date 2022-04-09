using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AreaEffectVisualisationRequest : redEvent
	{
		[Ordinal(0)] 
		[RED("areaEffectID")] 
		public CName AreaEffectID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AreaEffectVisualisationRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
