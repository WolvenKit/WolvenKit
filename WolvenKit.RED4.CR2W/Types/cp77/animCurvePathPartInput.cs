using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animCurvePathPartInput : CVariable
	{
		private CFloat _curveLengthStart;
		private CFloat _curveLengthEnd;
		private CName _controllerName;
		private CName _eventNameStart;
		private CName _eventNameEnd;
		private CFloat _startBlendTime;

		[Ordinal(0)] 
		[RED("curveLengthStart")] 
		public CFloat CurveLengthStart
		{
			get
			{
				if (_curveLengthStart == null)
				{
					_curveLengthStart = (CFloat) CR2WTypeManager.Create("Float", "curveLengthStart", cr2w, this);
				}
				return _curveLengthStart;
			}
			set
			{
				if (_curveLengthStart == value)
				{
					return;
				}
				_curveLengthStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("curveLengthEnd")] 
		public CFloat CurveLengthEnd
		{
			get
			{
				if (_curveLengthEnd == null)
				{
					_curveLengthEnd = (CFloat) CR2WTypeManager.Create("Float", "curveLengthEnd", cr2w, this);
				}
				return _curveLengthEnd;
			}
			set
			{
				if (_curveLengthEnd == value)
				{
					return;
				}
				_curveLengthEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("controllerName")] 
		public CName ControllerName
		{
			get
			{
				if (_controllerName == null)
				{
					_controllerName = (CName) CR2WTypeManager.Create("CName", "controllerName", cr2w, this);
				}
				return _controllerName;
			}
			set
			{
				if (_controllerName == value)
				{
					return;
				}
				_controllerName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("eventNameStart")] 
		public CName EventNameStart
		{
			get
			{
				if (_eventNameStart == null)
				{
					_eventNameStart = (CName) CR2WTypeManager.Create("CName", "eventNameStart", cr2w, this);
				}
				return _eventNameStart;
			}
			set
			{
				if (_eventNameStart == value)
				{
					return;
				}
				_eventNameStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("eventNameEnd")] 
		public CName EventNameEnd
		{
			get
			{
				if (_eventNameEnd == null)
				{
					_eventNameEnd = (CName) CR2WTypeManager.Create("CName", "eventNameEnd", cr2w, this);
				}
				return _eventNameEnd;
			}
			set
			{
				if (_eventNameEnd == value)
				{
					return;
				}
				_eventNameEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("startBlendTime")] 
		public CFloat StartBlendTime
		{
			get
			{
				if (_startBlendTime == null)
				{
					_startBlendTime = (CFloat) CR2WTypeManager.Create("Float", "startBlendTime", cr2w, this);
				}
				return _startBlendTime;
			}
			set
			{
				if (_startBlendTime == value)
				{
					return;
				}
				_startBlendTime = value;
				PropertySet(this);
			}
		}

		public animCurvePathPartInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
