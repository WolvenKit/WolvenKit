using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipModuleSpawnedCallbackData : IScriptable
	{
		[Ordinal(0)] 
		[RED("moduleName")] 
		public CName ModuleName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
