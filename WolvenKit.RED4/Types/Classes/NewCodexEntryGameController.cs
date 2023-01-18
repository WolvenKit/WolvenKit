using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewCodexEntryGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CHandle<NewCodexEntryUserData> Data
		{
			get => GetPropertyValue<CHandle<NewCodexEntryUserData>>();
			set => SetPropertyValue<CHandle<NewCodexEntryUserData>>(value);
		}

		public NewCodexEntryGameController()
		{
			Label = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
