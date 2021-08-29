using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBinkComponent : entIVisualComponent
	{
		private CHandle<gameBinkMeshTargetBinding> _meshTargetBinding;
		private CName _videoPlayerName;
		private CResourceAsyncReference<Bink> _binkResource;
		private CName _audioEvent;
		private CBool _loopVideo;
		private CBool _forceVideoFrameRate;
		private CBool _isEnabled;

		[Ordinal(8)] 
		[RED("meshTargetBinding")] 
		public CHandle<gameBinkMeshTargetBinding> MeshTargetBinding
		{
			get => GetProperty(ref _meshTargetBinding);
			set => SetProperty(ref _meshTargetBinding, value);
		}

		[Ordinal(9)] 
		[RED("videoPlayerName")] 
		public CName VideoPlayerName
		{
			get => GetProperty(ref _videoPlayerName);
			set => SetProperty(ref _videoPlayerName, value);
		}

		[Ordinal(10)] 
		[RED("binkResource")] 
		public CResourceAsyncReference<Bink> BinkResource
		{
			get => GetProperty(ref _binkResource);
			set => SetProperty(ref _binkResource, value);
		}

		[Ordinal(11)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get => GetProperty(ref _audioEvent);
			set => SetProperty(ref _audioEvent, value);
		}

		[Ordinal(12)] 
		[RED("loopVideo")] 
		public CBool LoopVideo
		{
			get => GetProperty(ref _loopVideo);
			set => SetProperty(ref _loopVideo, value);
		}

		[Ordinal(13)] 
		[RED("forceVideoFrameRate")] 
		public CBool ForceVideoFrameRate
		{
			get => GetProperty(ref _forceVideoFrameRate);
			set => SetProperty(ref _forceVideoFrameRate, value);
		}

		[Ordinal(14)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}
	}
}
