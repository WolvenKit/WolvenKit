using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexSystem : gameScriptableSystem
	{
		private CArray<SCodexRecord> _codex;
		private wCHandle<gameIBlackboard> _blackboard;

		[Ordinal(0)] 
		[RED("codex")] 
		public CArray<SCodexRecord> Codex
		{
			get => GetProperty(ref _codex);
			set => SetProperty(ref _codex, value);
		}

		[Ordinal(1)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		public CodexSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
