using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PuppetReactionDef : gamebbScriptDefinition
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

		public PuppetReactionDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
