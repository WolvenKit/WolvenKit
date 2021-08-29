using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StorageBlackboardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _storageData;

		[Ordinal(0)] 
		[RED("StorageData")] 
		public gamebbScriptID_Variant StorageData
		{
			get => GetProperty(ref _storageData);
			set => SetProperty(ref _storageData, value);
		}
	}
}
