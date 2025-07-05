using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class entIVisualComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("autoHideDistance")] 
		public CFloat AutoHideDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("renderSceneLayerMask")] 
		public CBitField<RenderSceneLayerMask> RenderSceneLayerMask
		{
			get => GetPropertyValue<CBitField<RenderSceneLayerMask>>();
			set => SetPropertyValue<CBitField<RenderSceneLayerMask>>(value);
		}

		[Ordinal(7)] 
		[RED("forceLODLevel")] 
		public CInt8 ForceLODLevel
		{
			get => GetPropertyValue<CInt8>();
			set => SetPropertyValue<CInt8>(value);
		}

		public entIVisualComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
