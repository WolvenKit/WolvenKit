using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workScriptedCondition : workIWorkspotCondition
	{
		private CHandle<workIScriptedCondition> _script;

		[Ordinal(2)] 
		[RED("script")] 
		public CHandle<workIScriptedCondition> Script
		{
			get => GetProperty(ref _script);
			set => SetProperty(ref _script, value);
		}
	}
}
