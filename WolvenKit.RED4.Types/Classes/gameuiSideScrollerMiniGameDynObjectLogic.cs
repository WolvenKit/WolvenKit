using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiSideScrollerMiniGameDynObjectLogic : inkWidgetLogicController
	{
		private CUInt32 _spawnPoolSize;

		[Ordinal(1)] 
		[RED("spawnPoolSize")] 
		public CUInt32 SpawnPoolSize
		{
			get => GetProperty(ref _spawnPoolSize);
			set => SetProperty(ref _spawnPoolSize, value);
		}
	}
}
