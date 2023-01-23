using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PauseMenuButtonItem : AnimatedListItemController
	{
		[Ordinal(30)] 
		[RED("Fluff")] 
		public inkTextWidgetReference Fluff
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("animLoop")] 
		public CHandle<inkanimProxy> AnimLoop
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public PauseMenuButtonItem()
		{
			Fluff = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
