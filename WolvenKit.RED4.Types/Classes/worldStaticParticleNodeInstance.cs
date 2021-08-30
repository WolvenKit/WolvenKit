using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldStaticParticleNodeInstance : worldINodeInstance
	{
		private CEnum<RenderSceneLayerMask> _renderLayerMask;

		[Ordinal(0)] 
		[RED("renderLayerMask")] 
		public CEnum<RenderSceneLayerMask> RenderLayerMask
		{
			get => GetProperty(ref _renderLayerMask);
			set => SetProperty(ref _renderLayerMask, value);
		}

		public worldStaticParticleNodeInstance()
		{
			_renderLayerMask = new() { Value = Enums.RenderSceneLayerMask.Default };
		}
	}
}
