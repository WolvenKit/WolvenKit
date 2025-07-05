using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeShooterHUDController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("selectedWeaponSlot")] 
		public inkImageWidgetReference SelectedWeaponSlot
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("secondWeaponSlot")] 
		public inkImageWidgetReference SecondWeaponSlot
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("thirdWeaponSlot")] 
		public inkImageWidgetReference ThirdWeaponSlot
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("healthContainer")] 
		public inkWidgetReference HealthContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("continueText")] 
		public inkWidgetReference ContinueText
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("continueCountdownWidget")] 
		public inkImageWidgetReference ContinueCountdownWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("levelName")] 
		public inkImageWidgetReference LevelName
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("levelNumber1")] 
		public inkImageWidgetReference LevelNumber1
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("levelNumber2")] 
		public inkImageWidgetReference LevelNumber2
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("levelFinishCard")] 
		public inkWidgetReference LevelFinishCard
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiarcadeShooterHUDController()
		{
			SelectedWeaponSlot = new inkImageWidgetReference();
			SecondWeaponSlot = new inkImageWidgetReference();
			ThirdWeaponSlot = new inkImageWidgetReference();
			HealthContainer = new inkWidgetReference();
			ContinueText = new inkWidgetReference();
			ContinueCountdownWidget = new inkImageWidgetReference();
			LevelName = new inkImageWidgetReference();
			LevelNumber1 = new inkImageWidgetReference();
			LevelNumber2 = new inkImageWidgetReference();
			LevelFinishCard = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
