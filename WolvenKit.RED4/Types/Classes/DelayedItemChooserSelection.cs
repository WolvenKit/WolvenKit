using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DelayedItemChooserSelection : redEvent
	{
		[Ordinal(0)] 
		[RED("selectLeftItemChooser")] 
		public CBool SelectLeftItemChooser
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DelayedItemChooserSelection()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
