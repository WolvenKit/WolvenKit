using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CharacterLevelUpGameController : gameuiHUDGameController
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
		[RED("stateChangesBlackboardId")] 
		public CUInt32 StateChangesBlackboardId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(12)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(13)] 
		[RED("data")] 
		public CHandle<LevelUpUserData> Data
		{
			get => GetPropertyValue<CHandle<LevelUpUserData>>();
			set => SetPropertyValue<CHandle<LevelUpUserData>>(value);
		}

		public CharacterLevelUpGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
