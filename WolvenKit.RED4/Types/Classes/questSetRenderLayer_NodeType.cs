using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetRenderLayer_NodeType : questIRenderFxManagerNodeType
	{
		[Ordinal(0)] 
		[RED("renderSceneLayer")] 
		public CEnum<RenderSceneLayer> RenderSceneLayer
		{
			get => GetPropertyValue<CEnum<RenderSceneLayer>>();
			set => SetPropertyValue<CEnum<RenderSceneLayer>>(value);
		}

		public questSetRenderLayer_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
