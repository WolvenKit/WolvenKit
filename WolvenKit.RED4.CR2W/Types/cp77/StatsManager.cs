using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatsManager : IScriptable
	{
		private CHandle<gameStatModifierData> _playerGodModeModifierData;

		[Ordinal(0)] 
		[RED("playerGodModeModifierData")] 
		public CHandle<gameStatModifierData> PlayerGodModeModifierData
		{
			get => GetProperty(ref _playerGodModeModifierData);
			set => SetProperty(ref _playerGodModeModifierData, value);
		}

		public StatsManager(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
