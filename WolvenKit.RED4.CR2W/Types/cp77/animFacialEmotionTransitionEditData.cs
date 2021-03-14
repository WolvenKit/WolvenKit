using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animFacialEmotionTransitionEditData : CVariable
	{
		private CName _toIdleMale;
		private CName _facialKeyMale;
		private CName _toIdleFemale;
		private CName _facialKeyFemale;
		private CEnum<animFacialEmotionTransitionType> _transitionType;
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
		[RED("facialKeyMale")] 
		public CName FacialKeyMale
		{
			get
			{
				if (_facialKeyMale == null)
				{
					_facialKeyMale = (CName) CR2WTypeManager.Create("CName", "facialKeyMale", cr2w, this);
				}
				return _facialKeyMale;
			}
			set
			{
				if (_facialKeyMale == value)
				{
					return;
				}
				_facialKeyMale = value;
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
		[RED("facialKeyFemale")] 
		public CName FacialKeyFemale
		{
			get
			{
				if (_facialKeyFemale == null)
				{
					_facialKeyFemale = (CName) CR2WTypeManager.Create("CName", "facialKeyFemale", cr2w, this);
				}
				return _facialKeyFemale;
			}
			set
			{
				if (_facialKeyFemale == value)
				{
					return;
				}
				_facialKeyFemale = value;
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		public animFacialEmotionTransitionEditData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
