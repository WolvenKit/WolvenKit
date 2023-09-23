using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleFocusClueEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("clueIndex")] 
		public CInt32 ClueIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("investigationState")] 
		public CEnum<EFocusClueInvestigationState> InvestigationState
		{
			get => GetPropertyValue<CEnum<EFocusClueInvestigationState>>();
			set => SetPropertyValue<CEnum<EFocusClueInvestigationState>>(value);
		}

		[Ordinal(3)] 
		[RED("updatePS")] 
		public CBool UpdatePS
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ToggleFocusClueEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
