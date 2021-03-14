using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioBreathingTemporaryStateMetadata : audioAudioMetadata
	{
		private CName _inhaleSound;
		private CName _exhaleSound;
		private CFloat _paramChangeSpeed;
		private CFloat _targetBpm;
		private CFloat _targetTimeDistortion;
		private CFloat _time;
		private CFloat _exhaustionChangeSpeed;
		private CFloat _targetExhaustion;
		private CEnum<audiobreathingLoopBehavior> _loopBehavior;
		private CBool _startStateFromBreath;

		[Ordinal(1)] 
		[RED("inhaleSound")] 
		public CName InhaleSound
		{
			get
			{
				if (_inhaleSound == null)
				{
					_inhaleSound = (CName) CR2WTypeManager.Create("CName", "inhaleSound", cr2w, this);
				}
				return _inhaleSound;
			}
			set
			{
				if (_inhaleSound == value)
				{
					return;
				}
				_inhaleSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("exhaleSound")] 
		public CName ExhaleSound
		{
			get
			{
				if (_exhaleSound == null)
				{
					_exhaleSound = (CName) CR2WTypeManager.Create("CName", "exhaleSound", cr2w, this);
				}
				return _exhaleSound;
			}
			set
			{
				if (_exhaleSound == value)
				{
					return;
				}
				_exhaleSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("paramChangeSpeed")] 
		public CFloat ParamChangeSpeed
		{
			get
			{
				if (_paramChangeSpeed == null)
				{
					_paramChangeSpeed = (CFloat) CR2WTypeManager.Create("Float", "paramChangeSpeed", cr2w, this);
				}
				return _paramChangeSpeed;
			}
			set
			{
				if (_paramChangeSpeed == value)
				{
					return;
				}
				_paramChangeSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("targetBpm")] 
		public CFloat TargetBpm
		{
			get
			{
				if (_targetBpm == null)
				{
					_targetBpm = (CFloat) CR2WTypeManager.Create("Float", "targetBpm", cr2w, this);
				}
				return _targetBpm;
			}
			set
			{
				if (_targetBpm == value)
				{
					return;
				}
				_targetBpm = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("targetTimeDistortion")] 
		public CFloat TargetTimeDistortion
		{
			get
			{
				if (_targetTimeDistortion == null)
				{
					_targetTimeDistortion = (CFloat) CR2WTypeManager.Create("Float", "targetTimeDistortion", cr2w, this);
				}
				return _targetTimeDistortion;
			}
			set
			{
				if (_targetTimeDistortion == value)
				{
					return;
				}
				_targetTimeDistortion = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("time")] 
		public CFloat Time
		{
			get
			{
				if (_time == null)
				{
					_time = (CFloat) CR2WTypeManager.Create("Float", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("exhaustionChangeSpeed")] 
		public CFloat ExhaustionChangeSpeed
		{
			get
			{
				if (_exhaustionChangeSpeed == null)
				{
					_exhaustionChangeSpeed = (CFloat) CR2WTypeManager.Create("Float", "exhaustionChangeSpeed", cr2w, this);
				}
				return _exhaustionChangeSpeed;
			}
			set
			{
				if (_exhaustionChangeSpeed == value)
				{
					return;
				}
				_exhaustionChangeSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("targetExhaustion")] 
		public CFloat TargetExhaustion
		{
			get
			{
				if (_targetExhaustion == null)
				{
					_targetExhaustion = (CFloat) CR2WTypeManager.Create("Float", "targetExhaustion", cr2w, this);
				}
				return _targetExhaustion;
			}
			set
			{
				if (_targetExhaustion == value)
				{
					return;
				}
				_targetExhaustion = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("loopBehavior")] 
		public CEnum<audiobreathingLoopBehavior> LoopBehavior
		{
			get
			{
				if (_loopBehavior == null)
				{
					_loopBehavior = (CEnum<audiobreathingLoopBehavior>) CR2WTypeManager.Create("audiobreathingLoopBehavior", "loopBehavior", cr2w, this);
				}
				return _loopBehavior;
			}
			set
			{
				if (_loopBehavior == value)
				{
					return;
				}
				_loopBehavior = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("startStateFromBreath")] 
		public CBool StartStateFromBreath
		{
			get
			{
				if (_startStateFromBreath == null)
				{
					_startStateFromBreath = (CBool) CR2WTypeManager.Create("Bool", "startStateFromBreath", cr2w, this);
				}
				return _startStateFromBreath;
			}
			set
			{
				if (_startStateFromBreath == value)
				{
					return;
				}
				_startStateFromBreath = value;
				PropertySet(this);
			}
		}

		public audioBreathingTemporaryStateMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
