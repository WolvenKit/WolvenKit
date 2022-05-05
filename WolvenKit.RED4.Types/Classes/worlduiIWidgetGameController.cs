using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worlduiIWidgetGameController : inkIWidgetController
	{
		[Ordinal(1)] 
		[RED("elementRecordID")] 
		public TweakDBID ElementRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public worlduiIWidgetGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
