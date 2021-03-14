using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SBraindanceInputMask : CVariable
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
			get
			{
				if (_pauseAction == null)
				{
					_pauseAction = (CBool) CR2WTypeManager.Create("Bool", "pauseAction", cr2w, this);
				}
				return _pauseAction;
			}
			set
			{
				if (_pauseAction == value)
				{
					return;
				}
				_pauseAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("playForwardAction")] 
		public CBool PlayForwardAction
		{
			get
			{
				if (_playForwardAction == null)
				{
					_playForwardAction = (CBool) CR2WTypeManager.Create("Bool", "playForwardAction", cr2w, this);
				}
				return _playForwardAction;
			}
			set
			{
				if (_playForwardAction == value)
				{
					return;
				}
				_playForwardAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("playBackwardAction")] 
		public CBool PlayBackwardAction
		{
			get
			{
				if (_playBackwardAction == null)
				{
					_playBackwardAction = (CBool) CR2WTypeManager.Create("Bool", "playBackwardAction", cr2w, this);
				}
				return _playBackwardAction;
			}
			set
			{
				if (_playBackwardAction == value)
				{
					return;
				}
				_playBackwardAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("restartAction")] 
		public CBool RestartAction
		{
			get
			{
				if (_restartAction == null)
				{
					_restartAction = (CBool) CR2WTypeManager.Create("Bool", "restartAction", cr2w, this);
				}
				return _restartAction;
			}
			set
			{
				if (_restartAction == value)
				{
					return;
				}
				_restartAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("switchLayerAction")] 
		public CBool SwitchLayerAction
		{
			get
			{
				if (_switchLayerAction == null)
				{
					_switchLayerAction = (CBool) CR2WTypeManager.Create("Bool", "switchLayerAction", cr2w, this);
				}
				return _switchLayerAction;
			}
			set
			{
				if (_switchLayerAction == value)
				{
					return;
				}
				_switchLayerAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("cameraToggleAction")] 
		public CBool CameraToggleAction
		{
			get
			{
				if (_cameraToggleAction == null)
				{
					_cameraToggleAction = (CBool) CR2WTypeManager.Create("Bool", "cameraToggleAction", cr2w, this);
				}
				return _cameraToggleAction;
			}
			set
			{
				if (_cameraToggleAction == value)
				{
					return;
				}
				_cameraToggleAction = value;
				PropertySet(this);
			}
		}

		public SBraindanceInputMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
