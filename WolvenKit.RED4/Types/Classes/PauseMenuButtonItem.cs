using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PauseMenuButtonItem : AnimatedListItemController
	{
		[Ordinal(33)] 
		[RED("Fluff")] 
		public inkTextWidgetReference Fluff
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("animLoop")] 
		public CHandle<inkanimProxy> AnimLoop
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public PauseMenuButtonItem()
		{
			Fluff = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
