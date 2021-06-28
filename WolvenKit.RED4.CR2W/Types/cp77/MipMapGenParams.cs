using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MipMapGenParams : CVariable
	{
		private CBool _applyToksvig_ShouldInvChannel;
		private CUInt8 _applyToksvig_Channel;
		private raRef<CBitmapTexture> _applyToksvig_sourceNormalMap;

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
		public raRef<CBitmapTexture> ApplyToksvig_sourceNormalMap
		{
			get => GetProperty(ref _applyToksvig_sourceNormalMap);
			set => SetProperty(ref _applyToksvig_sourceNormalMap, value);
		}

		public MipMapGenParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
