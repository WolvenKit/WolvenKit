using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ProficiencyTabButtonController : TabButtonController
	{
		[Ordinal(21)] 
		[RED("bottom_bar")] 
		public inkWidgetReference Bottom_bar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("proxy")] 
		public CHandle<inkanimProxy> Proxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(23)] 
		[RED("isToggledState")] 
		public CBool IsToggledState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ProficiencyTabButtonController()
		{
			Bottom_bar = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
