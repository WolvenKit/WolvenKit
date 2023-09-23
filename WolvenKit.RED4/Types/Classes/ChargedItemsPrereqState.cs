using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChargedItemsPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("chargesState")] 
		public CEnum<EChargesAmount> ChargesState
		{
			get => GetPropertyValue<CEnum<EChargesAmount>>();
			set => SetPropertyValue<CEnum<EChargesAmount>>(value);
		}

		[Ordinal(1)] 
		[RED("typeOfItem")] 
		public CEnum<EChargesItem> TypeOfItem
		{
			get => GetPropertyValue<CEnum<EChargesItem>>();
			set => SetPropertyValue<CEnum<EChargesItem>>(value);
		}

		[Ordinal(2)] 
		[RED("listener")] 
		public CHandle<BaseStatPoolPrereqListener> Listener
		{
			get => GetPropertyValue<CHandle<BaseStatPoolPrereqListener>>();
			set => SetPropertyValue<CHandle<BaseStatPoolPrereqListener>>(value);
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public ScriptGameInstance Owner
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		public ChargedItemsPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
