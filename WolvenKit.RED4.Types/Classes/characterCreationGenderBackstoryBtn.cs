using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class characterCreationGenderBackstoryBtn : inkButtonController
	{
		[Ordinal(10)] 
		[RED("selector")] 
		public inkWidgetReference Selector
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("fluffText")] 
		public inkWidgetReference FluffText
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public characterCreationGenderBackstoryBtn()
		{
			Selector = new();
			FluffText = new();
		}
	}
}
