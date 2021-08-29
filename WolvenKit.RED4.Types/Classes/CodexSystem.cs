using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CodexSystem : gameScriptableSystem
	{
		private CArray<SCodexRecord> _codex;
		private CWeakHandle<gameIBlackboard> _blackboard;

		[Ordinal(0)] 
		[RED("codex")] 
		public CArray<SCodexRecord> Codex
		{
			get => GetProperty(ref _codex);
			set => SetProperty(ref _codex, value);
		}

		[Ordinal(1)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}
	}
}
