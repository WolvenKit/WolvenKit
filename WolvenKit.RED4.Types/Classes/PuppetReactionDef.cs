using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PuppetReactionDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _exitReactionFlag;
		private gamebbScriptID_Bool _blockReactionFlag;

		[Ordinal(0)] 
		[RED("exitReactionFlag")] 
		public gamebbScriptID_Bool ExitReactionFlag
		{
			get => GetProperty(ref _exitReactionFlag);
			set => SetProperty(ref _exitReactionFlag, value);
		}

		[Ordinal(1)] 
		[RED("blockReactionFlag")] 
		public gamebbScriptID_Bool BlockReactionFlag
		{
			get => GetProperty(ref _blockReactionFlag);
			set => SetProperty(ref _blockReactionFlag, value);
		}
	}
}
