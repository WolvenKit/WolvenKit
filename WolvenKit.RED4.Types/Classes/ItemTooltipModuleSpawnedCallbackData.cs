using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipModuleSpawnedCallbackData : IScriptable
	{
		private CName _moduleName;

		[Ordinal(0)] 
		[RED("moduleName")] 
		public CName ModuleName
		{
			get => GetProperty(ref _moduleName);
			set => SetProperty(ref _moduleName, value);
		}
	}
}
