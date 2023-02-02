using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CodexSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("codex")] 
		public CArray<SCodexRecord> Codex
		{
			get => GetPropertyValue<CArray<SCodexRecord>>();
			set => SetPropertyValue<CArray<SCodexRecord>>(value);
		}

		[Ordinal(1)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		public CodexSystem()
		{
			Codex = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
