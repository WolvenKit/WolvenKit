using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiHUDVideoStartEvent : RedBaseClass
	{
		private CUInt64 _videoPathHash;
		private CBool _playOnHud;
		private CBool _fullScreen;
		private Vector2 _position;
		private Vector2 _size;
		private CBool _skippable;
		private CBool _isLooped;
		private CBool _forceVideoFrameRate;

		[Ordinal(0)] 
		[RED("videoPathHash")] 
		public CUInt64 VideoPathHash
		{
			get => GetProperty(ref _videoPathHash);
			set => SetProperty(ref _videoPathHash, value);
		}

		[Ordinal(1)] 
		[RED("playOnHud")] 
		public CBool PlayOnHud
		{
			get => GetProperty(ref _playOnHud);
			set => SetProperty(ref _playOnHud, value);
		}

		[Ordinal(2)] 
		[RED("fullScreen")] 
		public CBool FullScreen
		{
			get => GetProperty(ref _fullScreen);
			set => SetProperty(ref _fullScreen, value);
		}

		[Ordinal(3)] 
		[RED("position")] 
		public Vector2 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(4)] 
		[RED("size")] 
		public Vector2 Size
		{
			get => GetProperty(ref _size);
			set => SetProperty(ref _size, value);
		}

		[Ordinal(5)] 
		[RED("skippable")] 
		public CBool Skippable
		{
			get => GetProperty(ref _skippable);
			set => SetProperty(ref _skippable, value);
		}

		[Ordinal(6)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get => GetProperty(ref _isLooped);
			set => SetProperty(ref _isLooped, value);
		}

		[Ordinal(7)] 
		[RED("forceVideoFrameRate")] 
		public CBool ForceVideoFrameRate
		{
			get => GetProperty(ref _forceVideoFrameRate);
			set => SetProperty(ref _forceVideoFrameRate, value);
		}
	}
}
