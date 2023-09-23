using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimationLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("imageView")] 
		public inkImageWidgetReference ImageView
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public AnimationLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
