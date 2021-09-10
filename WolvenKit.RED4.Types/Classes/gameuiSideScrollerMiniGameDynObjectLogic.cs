using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiSideScrollerMiniGameDynObjectLogic : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("spawnPoolSize")] 
		public CUInt32 SpawnPoolSize
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
