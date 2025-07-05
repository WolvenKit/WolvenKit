using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStaticParticleNodeInstance : worldINodeInstance
	{
		[Ordinal(0)] 
		[RED("renderLayerMask")] 
		public CBitField<RenderSceneLayerMask> RenderLayerMask
		{
			get => GetPropertyValue<CBitField<RenderSceneLayerMask>>();
			set => SetPropertyValue<CBitField<RenderSceneLayerMask>>(value);
		}

		public worldStaticParticleNodeInstance()
		{
			RenderLayerMask = Enums.RenderSceneLayerMask.Default;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
