using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiSideScrollerMiniGameDynObjectLogic : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("spawnPoolSize")] 
		public CUInt32 SpawnPoolSize
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameuiSideScrollerMiniGameDynObjectLogic()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
