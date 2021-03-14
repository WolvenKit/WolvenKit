using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TimeDilationProgressWithInputEvents : TimeDilationEventsTransitions
	{
		private CFloat _targetTimeScale;
		private CFloat _lerpMultiplier;
		private CFloat _duration;
		private CFloat _previousTimeStamp;
		private CName _easeInCurve;
		private CName _easeOutCurve;

		[Ordinal(0)] 
		[RED("targetTimeScale")] 
		public CFloat TargetTimeScale
		{
			get
			{
				if (_targetTimeScale == null)
				{
					_targetTimeScale = (CFloat) CR2WTypeManager.Create("Float", "targetTimeScale", cr2w, this);
				}
				return _targetTimeScale;
			}
			set
			{
				if (_targetTimeScale == value)
				{
					return;
				}
				_targetTimeScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lerpMultiplier")] 
		public CFloat LerpMultiplier
		{
			get
			{
				if (_lerpMultiplier == null)
				{
					_lerpMultiplier = (CFloat) CR2WTypeManager.Create("Float", "lerpMultiplier", cr2w, this);
				}
				return _lerpMultiplier;
			}
			set
			{
				if (_lerpMultiplier == value)
				{
					return;
				}
				_lerpMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("previousTimeStamp")] 
		public CFloat PreviousTimeStamp
		{
			get
			{
				if (_previousTimeStamp == null)
				{
					_previousTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "previousTimeStamp", cr2w, this);
				}
				return _previousTimeStamp;
			}
			set
			{
				if (_previousTimeStamp == value)
				{
					return;
				}
				_previousTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("easeInCurve")] 
		public CName EaseInCurve
		{
			get
			{
				if (_easeInCurve == null)
				{
					_easeInCurve = (CName) CR2WTypeManager.Create("CName", "easeInCurve", cr2w, this);
				}
				return _easeInCurve;
			}
			set
			{
				if (_easeInCurve == value)
				{
					return;
				}
				_easeInCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("easeOutCurve")] 
		public CName EaseOutCurve
		{
			get
			{
				if (_easeOutCurve == null)
				{
					_easeOutCurve = (CName) CR2WTypeManager.Create("CName", "easeOutCurve", cr2w, this);
				}
				return _easeOutCurve;
			}
			set
			{
				if (_easeOutCurve == value)
				{
					return;
				}
				_easeOutCurve = value;
				PropertySet(this);
			}
		}

		public TimeDilationProgressWithInputEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
