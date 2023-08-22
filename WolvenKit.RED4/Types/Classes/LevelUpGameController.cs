using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LevelUpGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("proficencyLabel")] 
		public inkTextWidgetReference ProficencyLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(12)] 
		[RED("data")] 
		public CHandle<LevelUpUserData> Data
		{
			get => GetPropertyValue<CHandle<LevelUpUserData>>();
			set => SetPropertyValue<CHandle<LevelUpUserData>>(value);
		}

		public LevelUpGameController()
		{
			Value = new inkTextWidgetReference();
			ProficencyLabel = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
