using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameSessionDataSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("gameSessionDataModules")] 
		public CArray<CHandle<GameSessionDataModule>> GameSessionDataModules
		{
			get => GetPropertyValue<CArray<CHandle<GameSessionDataModule>>>();
			set => SetPropertyValue<CArray<CHandle<GameSessionDataModule>>>(value);
		}

		public GameSessionDataSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
