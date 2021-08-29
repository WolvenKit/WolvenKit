using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MipMapGenParams : RedBaseClass
	{
		private CBool _applyToksvig_ShouldInvChannel;
		private CUInt8 _applyToksvig_Channel;
		private CResourceAsyncReference<CBitmapTexture> _applyToksvig_sourceNormalMap;

		[Ordinal(0)] 
		[RED("applyToksvig_ShouldInvChannel")] 
		public CBool ApplyToksvig_ShouldInvChannel
		{
			get => GetProperty(ref _applyToksvig_ShouldInvChannel);
			set => SetProperty(ref _applyToksvig_ShouldInvChannel, value);
		}

		[Ordinal(1)] 
		[RED("applyToksvig_Channel")] 
		public CUInt8 ApplyToksvig_Channel
		{
			get => GetProperty(ref _applyToksvig_Channel);
			set => SetProperty(ref _applyToksvig_Channel, value);
		}

		[Ordinal(2)] 
		[RED("applyToksvig_sourceNormalMap")] 
		public CResourceAsyncReference<CBitmapTexture> ApplyToksvig_sourceNormalMap
		{
			get => GetProperty(ref _applyToksvig_sourceNormalMap);
			set => SetProperty(ref _applyToksvig_sourceNormalMap, value);
		}
	}
}
