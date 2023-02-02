using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ClearItemAppearanceTaskData : gameScriptTaskData
	{
		[Ordinal(0)] 
		[RED("ts")] 
		public CHandle<gameTransactionSystem> Ts
		{
			get => GetPropertyValue<CHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(1)] 
		[RED("area")] 
		public CEnum<gamedataEquipmentArea> Area
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		public ClearItemAppearanceTaskData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
