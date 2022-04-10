using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MipMapGenParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("applyToksvig_ShouldInvChannel")] 
		public CBool ApplyToksvig_ShouldInvChannel
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("applyToksvig_Channel")] 
		public CUInt8 ApplyToksvig_Channel
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(2)] 
		[RED("applyToksvig_sourceNormalMap")] 
		public CResourceAsyncReference<CBitmapTexture> ApplyToksvig_sourceNormalMap
		{
			get => GetPropertyValue<CResourceAsyncReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceAsyncReference<CBitmapTexture>>(value);
		}

		public MipMapGenParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
