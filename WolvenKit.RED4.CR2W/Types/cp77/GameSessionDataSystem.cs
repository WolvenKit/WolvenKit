using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameSessionDataSystem : gameScriptableSystem
	{
		private CArray<CHandle<GameSessionDataModule>> _gameSessionDataModules;

		[Ordinal(0)] 
		[RED("gameSessionDataModules")] 
		public CArray<CHandle<GameSessionDataModule>> GameSessionDataModules
		{
			get => GetProperty(ref _gameSessionDataModules);
			set => SetProperty(ref _gameSessionDataModules, value);
		}

		public GameSessionDataSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
