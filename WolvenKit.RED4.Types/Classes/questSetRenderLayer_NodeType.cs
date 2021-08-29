using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetRenderLayer_NodeType : questIRenderFxManagerNodeType
	{
		private CEnum<RenderSceneLayer> _renderSceneLayer;

		[Ordinal(0)] 
		[RED("renderSceneLayer")] 
		public CEnum<RenderSceneLayer> RenderSceneLayer
		{
			get => GetProperty(ref _renderSceneLayer);
			set => SetProperty(ref _renderSceneLayer, value);
		}
	}
}
