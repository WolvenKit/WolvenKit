using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseStimuliData : IScriptable
	{
		private CFloat _interval;
		private CBool _isReactionStim;
		private CBool _isSecurityAreaExclusive;
		private CFloat _fearValue;
		private CFloat _shockValue;
		private CFloat _sadValue;
		private CFloat _joyValue;
		private CFloat _surpriseValue;
		private CFloat _disgustValue;
		private CFloat _aggressiveValue;
		private CFloat _funnyValue;
		private CFloat _curiosityValue;
		private CInt32 _stimPriority;

		[Ordinal(0)] 
		[RED("interval")] 
		public CFloat Interval
		{
			get
			{
				if (_interval == null)
				{
					_interval = (CFloat) CR2WTypeManager.Create("Float", "interval", cr2w, this);
				}
				return _interval;
			}
			set
			{
				if (_interval == value)
				{
					return;
				}
				_interval = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isReactionStim")] 
		public CBool IsReactionStim
		{
			get
			{
				if (_isReactionStim == null)
				{
					_isReactionStim = (CBool) CR2WTypeManager.Create("Bool", "isReactionStim", cr2w, this);
				}
				return _isReactionStim;
			}
			set
			{
				if (_isReactionStim == value)
				{
					return;
				}
				_isReactionStim = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isSecurityAreaExclusive")] 
		public CBool IsSecurityAreaExclusive
		{
			get
			{
				if (_isSecurityAreaExclusive == null)
				{
					_isSecurityAreaExclusive = (CBool) CR2WTypeManager.Create("Bool", "isSecurityAreaExclusive", cr2w, this);
				}
				return _isSecurityAreaExclusive;
			}
			set
			{
				if (_isSecurityAreaExclusive == value)
				{
					return;
				}
				_isSecurityAreaExclusive = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("fearValue")] 
		public CFloat FearValue
		{
			get
			{
				if (_fearValue == null)
				{
					_fearValue = (CFloat) CR2WTypeManager.Create("Float", "fearValue", cr2w, this);
				}
				return _fearValue;
			}
			set
			{
				if (_fearValue == value)
				{
					return;
				}
				_fearValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("shockValue")] 
		public CFloat ShockValue
		{
			get
			{
				if (_shockValue == null)
				{
					_shockValue = (CFloat) CR2WTypeManager.Create("Float", "shockValue", cr2w, this);
				}
				return _shockValue;
			}
			set
			{
				if (_shockValue == value)
				{
					return;
				}
				_shockValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("sadValue")] 
		public CFloat SadValue
		{
			get
			{
				if (_sadValue == null)
				{
					_sadValue = (CFloat) CR2WTypeManager.Create("Float", "sadValue", cr2w, this);
				}
				return _sadValue;
			}
			set
			{
				if (_sadValue == value)
				{
					return;
				}
				_sadValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("joyValue")] 
		public CFloat JoyValue
		{
			get
			{
				if (_joyValue == null)
				{
					_joyValue = (CFloat) CR2WTypeManager.Create("Float", "joyValue", cr2w, this);
				}
				return _joyValue;
			}
			set
			{
				if (_joyValue == value)
				{
					return;
				}
				_joyValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("surpriseValue")] 
		public CFloat SurpriseValue
		{
			get
			{
				if (_surpriseValue == null)
				{
					_surpriseValue = (CFloat) CR2WTypeManager.Create("Float", "surpriseValue", cr2w, this);
				}
				return _surpriseValue;
			}
			set
			{
				if (_surpriseValue == value)
				{
					return;
				}
				_surpriseValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("disgustValue")] 
		public CFloat DisgustValue
		{
			get
			{
				if (_disgustValue == null)
				{
					_disgustValue = (CFloat) CR2WTypeManager.Create("Float", "disgustValue", cr2w, this);
				}
				return _disgustValue;
			}
			set
			{
				if (_disgustValue == value)
				{
					return;
				}
				_disgustValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("aggressiveValue")] 
		public CFloat AggressiveValue
		{
			get
			{
				if (_aggressiveValue == null)
				{
					_aggressiveValue = (CFloat) CR2WTypeManager.Create("Float", "aggressiveValue", cr2w, this);
				}
				return _aggressiveValue;
			}
			set
			{
				if (_aggressiveValue == value)
				{
					return;
				}
				_aggressiveValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("funnyValue")] 
		public CFloat FunnyValue
		{
			get
			{
				if (_funnyValue == null)
				{
					_funnyValue = (CFloat) CR2WTypeManager.Create("Float", "funnyValue", cr2w, this);
				}
				return _funnyValue;
			}
			set
			{
				if (_funnyValue == value)
				{
					return;
				}
				_funnyValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("curiosityValue")] 
		public CFloat CuriosityValue
		{
			get
			{
				if (_curiosityValue == null)
				{
					_curiosityValue = (CFloat) CR2WTypeManager.Create("Float", "curiosityValue", cr2w, this);
				}
				return _curiosityValue;
			}
			set
			{
				if (_curiosityValue == value)
				{
					return;
				}
				_curiosityValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("stimPriority")] 
		public CInt32 StimPriority
		{
			get
			{
				if (_stimPriority == null)
				{
					_stimPriority = (CInt32) CR2WTypeManager.Create("Int32", "stimPriority", cr2w, this);
				}
				return _stimPriority;
			}
			set
			{
				if (_stimPriority == value)
				{
					return;
				}
				_stimPriority = value;
				PropertySet(this);
			}
		}

		public senseStimuliData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
