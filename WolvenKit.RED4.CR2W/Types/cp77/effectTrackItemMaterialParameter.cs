using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemMaterialParameter : effectTrackItem
	{
		private CFloat _scale0;
		private effectEffectParameterEvaluator _customParameter0;
		private CFloat _scale1;
		private effectEffectParameterEvaluator _customParameter1;
		private CFloat _scale2;
		private effectEffectParameterEvaluator _customParameter2;
		private CFloat _scale3;
		private effectEffectParameterEvaluator _customParameter3;

		[Ordinal(3)] 
		[RED("scale0")] 
		public CFloat Scale0
		{
			get
			{
				if (_scale0 == null)
				{
					_scale0 = (CFloat) CR2WTypeManager.Create("Float", "scale0", cr2w, this);
				}
				return _scale0;
			}
			set
			{
				if (_scale0 == value)
				{
					return;
				}
				_scale0 = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("customParameter0")] 
		public effectEffectParameterEvaluator CustomParameter0
		{
			get
			{
				if (_customParameter0 == null)
				{
					_customParameter0 = (effectEffectParameterEvaluator) CR2WTypeManager.Create("effectEffectParameterEvaluator", "customParameter0", cr2w, this);
				}
				return _customParameter0;
			}
			set
			{
				if (_customParameter0 == value)
				{
					return;
				}
				_customParameter0 = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("scale1")] 
		public CFloat Scale1
		{
			get
			{
				if (_scale1 == null)
				{
					_scale1 = (CFloat) CR2WTypeManager.Create("Float", "scale1", cr2w, this);
				}
				return _scale1;
			}
			set
			{
				if (_scale1 == value)
				{
					return;
				}
				_scale1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("customParameter1")] 
		public effectEffectParameterEvaluator CustomParameter1
		{
			get
			{
				if (_customParameter1 == null)
				{
					_customParameter1 = (effectEffectParameterEvaluator) CR2WTypeManager.Create("effectEffectParameterEvaluator", "customParameter1", cr2w, this);
				}
				return _customParameter1;
			}
			set
			{
				if (_customParameter1 == value)
				{
					return;
				}
				_customParameter1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("scale2")] 
		public CFloat Scale2
		{
			get
			{
				if (_scale2 == null)
				{
					_scale2 = (CFloat) CR2WTypeManager.Create("Float", "scale2", cr2w, this);
				}
				return _scale2;
			}
			set
			{
				if (_scale2 == value)
				{
					return;
				}
				_scale2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("customParameter2")] 
		public effectEffectParameterEvaluator CustomParameter2
		{
			get
			{
				if (_customParameter2 == null)
				{
					_customParameter2 = (effectEffectParameterEvaluator) CR2WTypeManager.Create("effectEffectParameterEvaluator", "customParameter2", cr2w, this);
				}
				return _customParameter2;
			}
			set
			{
				if (_customParameter2 == value)
				{
					return;
				}
				_customParameter2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("scale3")] 
		public CFloat Scale3
		{
			get
			{
				if (_scale3 == null)
				{
					_scale3 = (CFloat) CR2WTypeManager.Create("Float", "scale3", cr2w, this);
				}
				return _scale3;
			}
			set
			{
				if (_scale3 == value)
				{
					return;
				}
				_scale3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("customParameter3")] 
		public effectEffectParameterEvaluator CustomParameter3
		{
			get
			{
				if (_customParameter3 == null)
				{
					_customParameter3 = (effectEffectParameterEvaluator) CR2WTypeManager.Create("effectEffectParameterEvaluator", "customParameter3", cr2w, this);
				}
				return _customParameter3;
			}
			set
			{
				if (_customParameter3 == value)
				{
					return;
				}
				_customParameter3 = value;
				PropertySet(this);
			}
		}

		public effectTrackItemMaterialParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
