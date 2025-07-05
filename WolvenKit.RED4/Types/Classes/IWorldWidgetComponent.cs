using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class IWorldWidgetComponent : WidgetBaseComponent
	{
		[Ordinal(5)] 
		[RED("glitchValue")] 
		public CFloat GlitchValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("tintColor")] 
		public CColor TintColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(7)] 
		[RED("screenAreaMultiplier")] 
		public CFloat ScreenAreaMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("textureMinMipBias")] 
		public CUInt32 TextureMinMipBias
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(9)] 
		[RED("textureMaxMipBias")] 
		public CUInt32 TextureMaxMipBias
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(10)] 
		[RED("meshTargetBinding")] 
		public CHandle<worlduiMeshTargetBinding> MeshTargetBinding
		{
			get => GetPropertyValue<CHandle<worlduiMeshTargetBinding>>();
			set => SetPropertyValue<CHandle<worlduiMeshTargetBinding>>(value);
		}

		[Ordinal(11)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public IWorldWidgetComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
