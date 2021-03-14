using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animFacialEmotionTransitionBaked : CVariable
	{
		private CName _toIdleMale;
		private CName _facialKey_Male;
		private CName _toIdleFemale;
		private CName _facialKey_Female;
		private CEnum<animFacialEmotionTransitionType> _transitionType;
		private CFloat _transitionDuration;
		private CFloat _timeScale;
		private CFloat _toIdleWeight;
		private CFloat _toIdleNeckWeight;
		private CFloat _facialKeyWeight;
		private CName _customTransitionAnim;

		[Ordinal(0)] 
		[RED("toIdleMale")] 
		public CName ToIdleMale
		{
			get
			{
				if (_toIdleMale == null)
				{
					_toIdleMale = (CName) CR2WTypeManager.Create("CName", "toIdleMale", cr2w, this);
				}
				return _toIdleMale;
			}
			set
			{
				if (_toIdleMale == value)
				{
					return;
				}
				_toIdleMale = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("facialKey_Male")] 
		public CName FacialKey_Male
		{
			get
			{
				if (_facialKey_Male == null)
				{
					_facialKey_Male = (CName) CR2WTypeManager.Create("CName", "facialKey_Male", cr2w, this);
				}
				return _facialKey_Male;
			}
			set
			{
				if (_facialKey_Male == value)
				{
					return;
				}
				_facialKey_Male = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("toIdleFemale")] 
		public CName ToIdleFemale
		{
			get
			{
				if (_toIdleFemale == null)
				{
					_toIdleFemale = (CName) CR2WTypeManager.Create("CName", "toIdleFemale", cr2w, this);
				}
				return _toIdleFemale;
			}
			set
			{
				if (_toIdleFemale == value)
				{
					return;
				}
				_toIdleFemale = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("facialKey_Female")] 
		public CName FacialKey_Female
		{
			get
			{
				if (_facialKey_Female == null)
				{
					_facialKey_Female = (CName) CR2WTypeManager.Create("CName", "facialKey_Female", cr2w, this);
				}
				return _facialKey_Female;
			}
			set
			{
				if (_facialKey_Female == value)
				{
					return;
				}
				_facialKey_Female = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("transitionType")] 
		public CEnum<animFacialEmotionTransitionType> TransitionType
		{
			get
			{
				if (_transitionType == null)
				{
					_transitionType = (CEnum<animFacialEmotionTransitionType>) CR2WTypeManager.Create("animFacialEmotionTransitionType", "transitionType", cr2w, this);
				}
				return _transitionType;
			}
			set
			{
				if (_transitionType == value)
				{
					return;
				}
				_transitionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("transitionDuration")] 
		public CFloat TransitionDuration
		{
			get
			{
				if (_transitionDuration == null)
				{
					_transitionDuration = (CFloat) CR2WTypeManager.Create("Float", "transitionDuration", cr2w, this);
				}
				return _transitionDuration;
			}
			set
			{
				if (_transitionDuration == value)
				{
					return;
				}
				_transitionDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get
			{
				if (_timeScale == null)
				{
					_timeScale = (CFloat) CR2WTypeManager.Create("Float", "timeScale", cr2w, this);
				}
				return _timeScale;
			}
			set
			{
				if (_timeScale == value)
				{
					return;
				}
				_timeScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("toIdleWeight")] 
		public CFloat ToIdleWeight
		{
			get
			{
				if (_toIdleWeight == null)
				{
					_toIdleWeight = (CFloat) CR2WTypeManager.Create("Float", "toIdleWeight", cr2w, this);
				}
				return _toIdleWeight;
			}
			set
			{
				if (_toIdleWeight == value)
				{
					return;
				}
				_toIdleWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("toIdleNeckWeight")] 
		public CFloat ToIdleNeckWeight
		{
			get
			{
				if (_toIdleNeckWeight == null)
				{
					_toIdleNeckWeight = (CFloat) CR2WTypeManager.Create("Float", "toIdleNeckWeight", cr2w, this);
				}
				return _toIdleNeckWeight;
			}
			set
			{
				if (_toIdleNeckWeight == value)
				{
					return;
				}
				_toIdleNeckWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("facialKeyWeight")] 
		public CFloat FacialKeyWeight
		{
			get
			{
				if (_facialKeyWeight == null)
				{
					_facialKeyWeight = (CFloat) CR2WTypeManager.Create("Float", "facialKeyWeight", cr2w, this);
				}
				return _facialKeyWeight;
			}
			set
			{
				if (_facialKeyWeight == value)
				{
					return;
				}
				_facialKeyWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("customTransitionAnim")] 
		public CName CustomTransitionAnim
		{
			get
			{
				if (_customTransitionAnim == null)
				{
					_customTransitionAnim = (CName) CR2WTypeManager.Create("CName", "customTransitionAnim", cr2w, this);
				}
				return _customTransitionAnim;
			}
			set
			{
				if (_customTransitionAnim == value)
				{
					return;
				}
				_customTransitionAnim = value;
				PropertySet(this);
			}
		}

		public animFacialEmotionTransitionBaked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
