using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entEntity : IScriptable
	{
		[Ordinal(0)] 
		[RED("customCameraTarget")] 
		public CEnum<ECustomCameraTarget> CustomCameraTarget
		{
			get => GetPropertyValue<CEnum<ECustomCameraTarget>>();
			set => SetPropertyValue<CEnum<ECustomCameraTarget>>(value);
		}

		[Ordinal(1)] 
		[RED("renderSceneLayerMask")] 
		public CBitField<RenderSceneLayerMask> RenderSceneLayerMask
		{
			get => GetPropertyValue<CBitField<RenderSceneLayerMask>>();
			set => SetPropertyValue<CBitField<RenderSceneLayerMask>>(value);
		}

		public entEntity()
		{
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
