using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatValueDebugProvider : CVariable
	{
		private CBool _isEnabled;
		private CFloat _min;
		private CFloat _max;
		private CFloat _progress;
		private CBool _auto;
		private CFloat _speed;
		private CBool _wrap;

		[Ordinal(0)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("min")] 
		public CFloat Min
		{
			get
			{
				if (_min == null)
				{
					_min = (CFloat) CR2WTypeManager.Create("Float", "min", cr2w, this);
				}
				return _min;
			}
			set
			{
				if (_min == value)
				{
					return;
				}
				_min = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("max")] 
		public CFloat Max
		{
			get
			{
				if (_max == null)
				{
					_max = (CFloat) CR2WTypeManager.Create("Float", "max", cr2w, this);
				}
				return _max;
			}
			set
			{
				if (_max == value)
				{
					return;
				}
				_max = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("progress")] 
		public CFloat Progress
		{
			get
			{
				if (_progress == null)
				{
					_progress = (CFloat) CR2WTypeManager.Create("Float", "progress", cr2w, this);
				}
				return _progress;
			}
			set
			{
				if (_progress == value)
				{
					return;
				}
				_progress = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("auto")] 
		public CBool Auto
		{
			get
			{
				if (_auto == null)
				{
					_auto = (CBool) CR2WTypeManager.Create("Bool", "auto", cr2w, this);
				}
				return _auto;
			}
			set
			{
				if (_auto == value)
				{
					return;
				}
				_auto = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get
			{
				if (_speed == null)
				{
					_speed = (CFloat) CR2WTypeManager.Create("Float", "speed", cr2w, this);
				}
				return _speed;
			}
			set
			{
				if (_speed == value)
				{
					return;
				}
				_speed = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("wrap")] 
		public CBool Wrap
		{
			get
			{
				if (_wrap == null)
				{
					_wrap = (CBool) CR2WTypeManager.Create("Bool", "wrap", cr2w, this);
				}
				return _wrap;
			}
			set
			{
				if (_wrap == value)
				{
					return;
				}
				_wrap = value;
				PropertySet(this);
			}
		}

		public animAnimNode_FloatValueDebugProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
