using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemLogPopupLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("quantity")] 
		public inkTextWidgetReference Quantity
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(6)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(7)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		public ItemLogPopupLogicController()
		{
			Quantity = new();
			Icon = new();
			Label = new();
			Duration = 3.000000F;
			AnimOptions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
