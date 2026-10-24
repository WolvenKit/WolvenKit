using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActivateDevice : ActionBool
	{
		[Ordinal(39)] 
		[RED("tweakDBChoiceName")] 
		public CString TweakDBChoiceName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public ActivateDevice()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
