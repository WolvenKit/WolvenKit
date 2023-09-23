using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ClothingSetIconButton : BaseButtonView
	{
		[Ordinal(5)] 
		[RED("setIcon")] 
		public inkImageWidgetReference SetIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("currentIconFrame")] 
		public inkWidgetReference CurrentIconFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("iconID")] 
		public TweakDBID IconID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public ClothingSetIconButton()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
