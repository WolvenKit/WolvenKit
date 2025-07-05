using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldMinimapModeOverrideAreaNode : worldTriggerAreaNode
	{
		[Ordinal(7)] 
		[RED("streamingOcclusion")] 
		public CEnum<worldPrefabStreamingOcclusion> StreamingOcclusion
		{
			get => GetPropertyValue<CEnum<worldPrefabStreamingOcclusion>>();
			set => SetPropertyValue<CEnum<worldPrefabStreamingOcclusion>>(value);
		}

		public worldMinimapModeOverrideAreaNode()
		{
			StreamingOcclusion = Enums.worldPrefabStreamingOcclusion.Interior;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
