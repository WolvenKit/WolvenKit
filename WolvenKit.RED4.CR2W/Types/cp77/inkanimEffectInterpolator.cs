using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimEffectInterpolator : inkanimInterpolator
	{
		private CFloat _startValue;
		private CFloat _endValue;
		private CEnum<inkEffectType> _effectType;
		private CName _effectName;
		private CName _paramName;

		[Ordinal(7)] 
		[RED("startValue")] 
		public CFloat StartValue
		{
			get
			{
				if (_startValue == null)
				{
					_startValue = (CFloat) CR2WTypeManager.Create("Float", "startValue", cr2w, this);
				}
				return _startValue;
			}
			set
			{
				if (_startValue == value)
				{
					return;
				}
				_startValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("endValue")] 
		public CFloat EndValue
		{
			get
			{
				if (_endValue == null)
				{
					_endValue = (CFloat) CR2WTypeManager.Create("Float", "endValue", cr2w, this);
				}
				return _endValue;
			}
			set
			{
				if (_endValue == value)
				{
					return;
				}
				_endValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("effectType")] 
		public CEnum<inkEffectType> EffectType
		{
			get
			{
				if (_effectType == null)
				{
					_effectType = (CEnum<inkEffectType>) CR2WTypeManager.Create("inkEffectType", "effectType", cr2w, this);
				}
				return _effectType;
			}
			set
			{
				if (_effectType == value)
				{
					return;
				}
				_effectType = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get
			{
				if (_effectName == null)
				{
					_effectName = (CName) CR2WTypeManager.Create("CName", "effectName", cr2w, this);
				}
				return _effectName;
			}
			set
			{
				if (_effectName == value)
				{
					return;
				}
				_effectName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("paramName")] 
		public CName ParamName
		{
			get
			{
				if (_paramName == null)
				{
					_paramName = (CName) CR2WTypeManager.Create("CName", "paramName", cr2w, this);
				}
				return _paramName;
			}
			set
			{
				if (_paramName == value)
				{
					return;
				}
				_paramName = value;
				PropertySet(this);
			}
		}

		public inkanimEffectInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
