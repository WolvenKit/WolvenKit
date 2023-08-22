using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ClothingSetIconButton : BaseButtonView
	{
		[Ordinal(2)] 
		[RED("setIcon")] 
		public inkImageWidgetReference SetIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("currentIconFrame")] 
		public inkWidgetReference CurrentIconFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("iconID")] 
		public TweakDBID IconID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public ClothingSetIconButton()
		{
			SetIcon = new inkImageWidgetReference();
			CurrentIconFrame = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
