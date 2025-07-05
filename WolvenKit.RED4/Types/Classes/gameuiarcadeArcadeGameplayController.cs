using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gameuiarcadeArcadeGameplayController : gameuiarcadeIArcadeScreenController
	{
		[Ordinal(1)] 
		[RED("score")] 
		public inkWidgetReference Score
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("pauseText")] 
		public inkWidgetReference PauseText
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiarcadeArcadeGameplayController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
