using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCompositionInterpolator : CVariable
	{
		private CName _parameter;
		private CEnum<inkanimInterpolationMode> _interpolationMode;
		private CEnum<inkanimInterpolationType> _interpolationType;
		private CFloat _duration;
		private CFloat _startDelay;

		[Ordinal(0)] 
		[RED("parameter")] 
		public CName Parameter
		{
			get
			{
				if (_parameter == null)
				{
					_parameter = (CName) CR2WTypeManager.Create("CName", "parameter", cr2w, this);
				}
				return _parameter;
			}
			set
			{
				if (_parameter == value)
				{
					return;
				}
				_parameter = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		public inkCompositionInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
