using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldMinimapModeOverrideAreaNode : worldTriggerAreaNode
	{
		[Ordinal(5)] 
		[RED("streamingOcclusion")] 
		public CEnum<worldPrefabStreamingOcclusion> StreamingOcclusion
		{
			get => GetPropertyValue<CEnum<worldPrefabStreamingOcclusion>>();
			set => SetPropertyValue<CEnum<worldPrefabStreamingOcclusion>>(value);
		}

		public worldMinimapModeOverrideAreaNode()
		{
			Color = new CColor { Red = 64, Green = 144, Blue = 160, Alpha = 128 };
			StreamingOcclusion = Enums.worldPrefabStreamingOcclusion.Interior;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
