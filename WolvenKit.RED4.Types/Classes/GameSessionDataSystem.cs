using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameSessionDataSystem : gameScriptableSystem
	{
		private CArray<CHandle<GameSessionDataModule>> _gameSessionDataModules;

		[Ordinal(0)] 
		[RED("gameSessionDataModules")] 
		public CArray<CHandle<GameSessionDataModule>> GameSessionDataModules
		{
			get => GetProperty(ref _gameSessionDataModules);
			set => SetProperty(ref _gameSessionDataModules, value);
		}
	}
}
