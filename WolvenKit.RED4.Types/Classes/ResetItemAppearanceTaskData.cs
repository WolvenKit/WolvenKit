using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetItemAppearanceTaskData : gameScriptTaskData
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

		[Ordinal(2)] 
		[RED("force")] 
		public CBool Force
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
