using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TVSetup : CVariable
	{
		private CArray<STvChannel> _channels;
		private CInt32 _initialChannel;
		private TweakDBID _initialGlobalTvChannel;
		private CBool _muteInterface;
		private CBool _isInteractive;
		private CBool _isGlobalTvOnly;

		[Ordinal(0)] 
		[RED("channels")] 
		public CArray<STvChannel> Channels
		{
			get => GetProperty(ref _channels);
			set => SetProperty(ref _channels, value);
		}

		[Ordinal(1)] 
		[RED("initialChannel")] 
		public CInt32 InitialChannel
		{
			get => GetProperty(ref _initialChannel);
			set => SetProperty(ref _initialChannel, value);
		}

		[Ordinal(2)] 
		[RED("initialGlobalTvChannel")] 
		public TweakDBID InitialGlobalTvChannel
		{
			get => GetProperty(ref _initialGlobalTvChannel);
			set => SetProperty(ref _initialGlobalTvChannel, value);
		}

		[Ordinal(3)] 
		[RED("muteInterface")] 
		public CBool MuteInterface
		{
			get => GetProperty(ref _muteInterface);
			set => SetProperty(ref _muteInterface, value);
		}

		[Ordinal(4)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetProperty(ref _isInteractive);
			set => SetProperty(ref _isInteractive, value);
		}

		[Ordinal(5)] 
		[RED("isGlobalTvOnly")] 
		public CBool IsGlobalTvOnly
		{
			get => GetProperty(ref _isGlobalTvOnly);
			set => SetProperty(ref _isGlobalTvOnly, value);
		}

		public TVSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
