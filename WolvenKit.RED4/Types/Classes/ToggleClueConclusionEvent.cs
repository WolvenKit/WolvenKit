using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleClueConclusionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("toggleConclusion")] 
		public CBool ToggleConclusion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("clueID")] 
		public CInt32 ClueID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("updatePS")] 
		public CBool UpdatePS
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ToggleClueConclusionEvent()
		{
			UpdatePS = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
