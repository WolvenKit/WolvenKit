using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SBraindanceInputMask : RedBaseClass
	{
		private CBool _pauseAction;
		private CBool _playForwardAction;
		private CBool _playBackwardAction;
		private CBool _restartAction;
		private CBool _switchLayerAction;
		private CBool _cameraToggleAction;

		[Ordinal(0)] 
		[RED("pauseAction")] 
		public CBool PauseAction
		{
			get => GetProperty(ref _pauseAction);
			set => SetProperty(ref _pauseAction, value);
		}

		[Ordinal(1)] 
		[RED("playForwardAction")] 
		public CBool PlayForwardAction
		{
			get => GetProperty(ref _playForwardAction);
			set => SetProperty(ref _playForwardAction, value);
		}

		[Ordinal(2)] 
		[RED("playBackwardAction")] 
		public CBool PlayBackwardAction
		{
			get => GetProperty(ref _playBackwardAction);
			set => SetProperty(ref _playBackwardAction, value);
		}

		[Ordinal(3)] 
		[RED("restartAction")] 
		public CBool RestartAction
		{
			get => GetProperty(ref _restartAction);
			set => SetProperty(ref _restartAction, value);
		}

		[Ordinal(4)] 
		[RED("switchLayerAction")] 
		public CBool SwitchLayerAction
		{
			get => GetProperty(ref _switchLayerAction);
			set => SetProperty(ref _switchLayerAction, value);
		}

		[Ordinal(5)] 
		[RED("cameraToggleAction")] 
		public CBool CameraToggleAction
		{
			get => GetProperty(ref _cameraToggleAction);
			set => SetProperty(ref _cameraToggleAction, value);
		}
	}
}
