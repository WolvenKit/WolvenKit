using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BackdoorInkGameController : MasterDeviceInkGameControllerBase
	{
		private inkWidgetReference _idleGroup;
		private inkWidgetReference _connectedGroup;
		private CName _introAnimationName;
		private CName _idleAnimationName;
		private CName _glitchAnimationName;
		private CHandle<inkanimProxy> _runningAnimation;
		private CUInt32 _onGlitchingListener;
		private CUInt32 _onIsInDefaultStateListener;
		private CUInt32 _onShutdownModuleListener;
		private CUInt32 _onBootModuleListener;

		[Ordinal(18)] 
		[RED("IdleGroup")] 
		public inkWidgetReference IdleGroup
		{
			get
			{
				if (_idleGroup == null)
				{
					_idleGroup = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "IdleGroup", cr2w, this);
				}
				return _idleGroup;
			}
			set
			{
				if (_idleGroup == value)
				{
					return;
				}
				_idleGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("ConnectedGroup")] 
		public inkWidgetReference ConnectedGroup
		{
			get
			{
				if (_connectedGroup == null)
				{
					_connectedGroup = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "ConnectedGroup", cr2w, this);
				}
				return _connectedGroup;
			}
			set
			{
				if (_connectedGroup == value)
				{
					return;
				}
				_connectedGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("IntroAnimationName")] 
		public CName IntroAnimationName
		{
			get
			{
				if (_introAnimationName == null)
				{
					_introAnimationName = (CName) CR2WTypeManager.Create("CName", "IntroAnimationName", cr2w, this);
				}
				return _introAnimationName;
			}
			set
			{
				if (_introAnimationName == value)
				{
					return;
				}
				_introAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("IdleAnimationName")] 
		public CName IdleAnimationName
		{
			get
			{
				if (_idleAnimationName == null)
				{
					_idleAnimationName = (CName) CR2WTypeManager.Create("CName", "IdleAnimationName", cr2w, this);
				}
				return _idleAnimationName;
			}
			set
			{
				if (_idleAnimationName == value)
				{
					return;
				}
				_idleAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("GlitchAnimationName")] 
		public CName GlitchAnimationName
		{
			get
			{
				if (_glitchAnimationName == null)
				{
					_glitchAnimationName = (CName) CR2WTypeManager.Create("CName", "GlitchAnimationName", cr2w, this);
				}
				return _glitchAnimationName;
			}
			set
			{
				if (_glitchAnimationName == value)
				{
					return;
				}
				_glitchAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("RunningAnimation")] 
		public CHandle<inkanimProxy> RunningAnimation
		{
			get
			{
				if (_runningAnimation == null)
				{
					_runningAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "RunningAnimation", cr2w, this);
				}
				return _runningAnimation;
			}
			set
			{
				if (_runningAnimation == value)
				{
					return;
				}
				_runningAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("onGlitchingListener")] 
		public CUInt32 OnGlitchingListener
		{
			get
			{
				if (_onGlitchingListener == null)
				{
					_onGlitchingListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onGlitchingListener", cr2w, this);
				}
				return _onGlitchingListener;
			}
			set
			{
				if (_onGlitchingListener == value)
				{
					return;
				}
				_onGlitchingListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("onIsInDefaultStateListener")] 
		public CUInt32 OnIsInDefaultStateListener
		{
			get
			{
				if (_onIsInDefaultStateListener == null)
				{
					_onIsInDefaultStateListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onIsInDefaultStateListener", cr2w, this);
				}
				return _onIsInDefaultStateListener;
			}
			set
			{
				if (_onIsInDefaultStateListener == value)
				{
					return;
				}
				_onIsInDefaultStateListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("onShutdownModuleListener")] 
		public CUInt32 OnShutdownModuleListener
		{
			get
			{
				if (_onShutdownModuleListener == null)
				{
					_onShutdownModuleListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onShutdownModuleListener", cr2w, this);
				}
				return _onShutdownModuleListener;
			}
			set
			{
				if (_onShutdownModuleListener == value)
				{
					return;
				}
				_onShutdownModuleListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("onBootModuleListener")] 
		public CUInt32 OnBootModuleListener
		{
			get
			{
				if (_onBootModuleListener == null)
				{
					_onBootModuleListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onBootModuleListener", cr2w, this);
				}
				return _onBootModuleListener;
			}
			set
			{
				if (_onBootModuleListener == value)
				{
					return;
				}
				_onBootModuleListener = value;
				PropertySet(this);
			}
		}

		public BackdoorInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
