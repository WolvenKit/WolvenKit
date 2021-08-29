using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class characterCreationGenderBackstoryBtn : inkButtonController
	{
		private inkWidgetReference _selector;
		private inkWidgetReference _fluffText;

		[Ordinal(10)] 
		[RED("selector")] 
		public inkWidgetReference Selector
		{
			get => GetProperty(ref _selector);
			set => SetProperty(ref _selector, value);
		}

		[Ordinal(11)] 
		[RED("fluffText")] 
		public inkWidgetReference FluffText
		{
			get => GetProperty(ref _fluffText);
			set => SetProperty(ref _fluffText, value);
		}
	}
}
