using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			StorageData = new();
		}
	}
}
