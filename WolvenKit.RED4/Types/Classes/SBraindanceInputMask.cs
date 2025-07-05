using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SBraindanceInputMask : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("pauseAction")] 
		public CBool PauseAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("playForwardAction")] 
		public CBool PlayForwardAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("playBackwardAction")] 
		public CBool PlayBackwardAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("restartAction")] 
		public CBool RestartAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("switchLayerAction")] 
		public CBool SwitchLayerAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("cameraToggleAction")] 
		public CBool CameraToggleAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SBraindanceInputMask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
