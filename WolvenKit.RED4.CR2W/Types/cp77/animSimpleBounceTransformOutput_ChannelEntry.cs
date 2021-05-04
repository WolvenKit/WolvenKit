using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSimpleBounceTransformOutput_ChannelEntry : CVariable
	{
		private CEnum<animTransformChannel> _transformChannel;
		private CFloat _multiplier;

		[Ordinal(0)] 
		[RED("transformChannel")] 
		public CEnum<animTransformChannel> TransformChannel
		{
			get => GetProperty(ref _transformChannel);
			set => SetProperty(ref _transformChannel, value);
		}

		[Ordinal(1)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get => GetProperty(ref _multiplier);
			set => SetProperty(ref _multiplier, value);
		}

		public animSimpleBounceTransformOutput_ChannelEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
