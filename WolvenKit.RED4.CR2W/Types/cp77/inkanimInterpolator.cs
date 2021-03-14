using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimInterpolator : IScriptable
	{
		private CEnum<inkanimInterpolationMode> _interpolationMode;
		private CEnum<inkanimInterpolationType> _interpolationType;
		private CEnum<inkanimInterpolationDirection> _interpolationDirection;
		private CFloat _duration;
		private CFloat _startDelay;
		private CBool _useRelativeDuration;
		private CBool _isAdditive;

		[Ordinal(0)] 
		[RED("interpolationMode")] 
		public CEnum<inkanimInterpolationMode> InterpolationMode
		{
			get
			{
				if (_interpolationMode == null)
				{
					_interpolationMode = (CEnum<inkanimInterpolationMode>) CR2WTypeManager.Create("inkanimInterpolationMode", "interpolationMode", cr2w, this);
				}
				return _interpolationMode;
			}
			set
			{
				if (_interpolationMode == value)
				{
					return;
				}
				_interpolationMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("interpolationType")] 
		public CEnum<inkanimInterpolationType> InterpolationType
		{
			get
			{
				if (_interpolationType == null)
				{
					_interpolationType = (CEnum<inkanimInterpolationType>) CR2WTypeManager.Create("inkanimInterpolationType", "interpolationType", cr2w, this);
				}
				return _interpolationType;
			}
			set
			{
				if (_interpolationType == value)
				{
					return;
				}
				_interpolationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("interpolationDirection")] 
		public CEnum<inkanimInterpolationDirection> InterpolationDirection
		{
			get
			{
				if (_interpolationDirection == null)
				{
					_interpolationDirection = (CEnum<inkanimInterpolationDirection>) CR2WTypeManager.Create("inkanimInterpolationDirection", "interpolationDirection", cr2w, this);
				}
				return _interpolationDirection;
			}
			set
			{
				if (_interpolationDirection == value)
				{
					return;
				}
				_interpolationDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("startDelay")] 
		public CFloat StartDelay
		{
			get
			{
				if (_startDelay == null)
				{
					_startDelay = (CFloat) CR2WTypeManager.Create("Float", "startDelay", cr2w, this);
				}
				return _startDelay;
			}
			set
			{
				if (_startDelay == value)
				{
					return;
				}
				_startDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("useRelativeDuration")] 
		public CBool UseRelativeDuration
		{
			get
			{
				if (_useRelativeDuration == null)
				{
					_useRelativeDuration = (CBool) CR2WTypeManager.Create("Bool", "useRelativeDuration", cr2w, this);
				}
				return _useRelativeDuration;
			}
			set
			{
				if (_useRelativeDuration == value)
				{
					return;
				}
				_useRelativeDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isAdditive")] 
		public CBool IsAdditive
		{
			get
			{
				if (_isAdditive == null)
				{
					_isAdditive = (CBool) CR2WTypeManager.Create("Bool", "isAdditive", cr2w, this);
				}
				return _isAdditive;
			}
			set
			{
				if (_isAdditive == value)
				{
					return;
				}
				_isAdditive = value;
				PropertySet(this);
			}
		}

		public inkanimInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
