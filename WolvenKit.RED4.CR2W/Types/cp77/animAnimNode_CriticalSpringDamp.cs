using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_CriticalSpringDamp : animAnimNode_FloatValue
	{
		private CFloat _smoothTime;
		private CBool _useRange;
		private CFloat _rangeMin;
		private CFloat _rangeMax;
		private animFloatLink _inputNode;

		[Ordinal(11)] 
		[RED("smoothTime")] 
		public CFloat SmoothTime
		{
			get
			{
				if (_smoothTime == null)
				{
					_smoothTime = (CFloat) CR2WTypeManager.Create("Float", "smoothTime", cr2w, this);
				}
				return _smoothTime;
			}
			set
			{
				if (_smoothTime == value)
				{
					return;
				}
				_smoothTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("useRange")] 
		public CBool UseRange
		{
			get
			{
				if (_useRange == null)
				{
					_useRange = (CBool) CR2WTypeManager.Create("Bool", "useRange", cr2w, this);
				}
				return _useRange;
			}
			set
			{
				if (_useRange == value)
				{
					return;
				}
				_useRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("rangeMin")] 
		public CFloat RangeMin
		{
			get
			{
				if (_rangeMin == null)
				{
					_rangeMin = (CFloat) CR2WTypeManager.Create("Float", "rangeMin", cr2w, this);
				}
				return _rangeMin;
			}
			set
			{
				if (_rangeMin == value)
				{
					return;
				}
				_rangeMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("rangeMax")] 
		public CFloat RangeMax
		{
			get
			{
				if (_rangeMax == null)
				{
					_rangeMax = (CFloat) CR2WTypeManager.Create("Float", "rangeMax", cr2w, this);
				}
				return _rangeMax;
			}
			set
			{
				if (_rangeMax == value)
				{
					return;
				}
				_rangeMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("inputNode")] 
		public animFloatLink InputNode
		{
			get
			{
				if (_inputNode == null)
				{
					_inputNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "inputNode", cr2w, this);
				}
				return _inputNode;
			}
			set
			{
				if (_inputNode == value)
				{
					return;
				}
				_inputNode = value;
				PropertySet(this);
			}
		}

		public animAnimNode_CriticalSpringDamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
