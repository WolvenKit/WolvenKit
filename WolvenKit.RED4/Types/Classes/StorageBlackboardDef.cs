using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StorageBlackboardDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("StorageData")] 
		public gamebbScriptID_Variant StorageData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public StorageBlackboardDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
