using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ValueBySpeed : animAnimNode_FloatValue
	{
		private CFloat _defaultValue;
		private CEnum<animClampType> _clampType;
		private CFloat _rangeMin;
		private CFloat _rangeMax;
		private CBool _resetOnActivation;
		private animFloatLink _speed;

		[Ordinal(11)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get
			{
				if (_defaultValue == null)
				{
					_defaultValue = (CFloat) CR2WTypeManager.Create("Float", "defaultValue", cr2w, this);
				}
				return _defaultValue;
			}
			set
			{
				if (_defaultValue == value)
				{
					return;
				}
				_defaultValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("clampType")] 
		public CEnum<animClampType> ClampType
		{
			get
			{
				if (_clampType == null)
				{
					_clampType = (CEnum<animClampType>) CR2WTypeManager.Create("animClampType", "clampType", cr2w, this);
				}
				return _clampType;
			}
			set
			{
				if (_clampType == value)
				{
					return;
				}
				_clampType = value;
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
		[RED("resetOnActivation")] 
		public CBool ResetOnActivation
		{
			get
			{
				if (_resetOnActivation == null)
				{
					_resetOnActivation = (CBool) CR2WTypeManager.Create("Bool", "resetOnActivation", cr2w, this);
				}
				return _resetOnActivation;
			}
			set
			{
				if (_resetOnActivation == value)
				{
					return;
				}
				_resetOnActivation = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("speed")] 
		public animFloatLink Speed
		{
			get
			{
				if (_speed == null)
				{
					_speed = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "speed", cr2w, this);
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

		public animAnimNode_ValueBySpeed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
