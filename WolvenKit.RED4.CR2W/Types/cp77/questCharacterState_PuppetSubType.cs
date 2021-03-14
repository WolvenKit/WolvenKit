using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterState_PuppetSubType : questICharacterConditionSubType
	{
		private gameEntityReference _puppetRef;
		private CEnum<questEComparisonTypeEquality> _upperBodyComparisonType;
		private CInt32 _upperBodyState;
		private CEnum<questEComparisonTypeEquality> _highLevelComparisonType;
		private CInt32 _highLevelState;
		private CEnum<questEComparisonTypeEquality> _stanceComparisonType;
		private CInt32 _stanceState;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get
			{
				if (_puppetRef == null)
				{
					_puppetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "puppetRef", cr2w, this);
				}
				return _puppetRef;
			}
			set
			{
				if (_puppetRef == value)
				{
					return;
				}
				_puppetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("upperBodyComparisonType")] 
		public CEnum<questEComparisonTypeEquality> UpperBodyComparisonType
		{
			get
			{
				if (_upperBodyComparisonType == null)
				{
					_upperBodyComparisonType = (CEnum<questEComparisonTypeEquality>) CR2WTypeManager.Create("questEComparisonTypeEquality", "upperBodyComparisonType", cr2w, this);
				}
				return _upperBodyComparisonType;
			}
			set
			{
				if (_upperBodyComparisonType == value)
				{
					return;
				}
				_upperBodyComparisonType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("upperBodyState")] 
		public CInt32 UpperBodyState
		{
			get
			{
				if (_upperBodyState == null)
				{
					_upperBodyState = (CInt32) CR2WTypeManager.Create("Int32", "upperBodyState", cr2w, this);
				}
				return _upperBodyState;
			}
			set
			{
				if (_upperBodyState == value)
				{
					return;
				}
				_upperBodyState = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("highLevelComparisonType")] 
		public CEnum<questEComparisonTypeEquality> HighLevelComparisonType
		{
			get
			{
				if (_highLevelComparisonType == null)
				{
					_highLevelComparisonType = (CEnum<questEComparisonTypeEquality>) CR2WTypeManager.Create("questEComparisonTypeEquality", "highLevelComparisonType", cr2w, this);
				}
				return _highLevelComparisonType;
			}
			set
			{
				if (_highLevelComparisonType == value)
				{
					return;
				}
				_highLevelComparisonType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("highLevelState")] 
		public CInt32 HighLevelState
		{
			get
			{
				if (_highLevelState == null)
				{
					_highLevelState = (CInt32) CR2WTypeManager.Create("Int32", "highLevelState", cr2w, this);
				}
				return _highLevelState;
			}
			set
			{
				if (_highLevelState == value)
				{
					return;
				}
				_highLevelState = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("stanceComparisonType")] 
		public CEnum<questEComparisonTypeEquality> StanceComparisonType
		{
			get
			{
				if (_stanceComparisonType == null)
				{
					_stanceComparisonType = (CEnum<questEComparisonTypeEquality>) CR2WTypeManager.Create("questEComparisonTypeEquality", "stanceComparisonType", cr2w, this);
				}
				return _stanceComparisonType;
			}
			set
			{
				if (_stanceComparisonType == value)
				{
					return;
				}
				_stanceComparisonType = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("stanceState")] 
		public CInt32 StanceState
		{
			get
			{
				if (_stanceState == null)
				{
					_stanceState = (CInt32) CR2WTypeManager.Create("Int32", "stanceState", cr2w, this);
				}
				return _stanceState;
			}
			set
			{
				if (_stanceState == value)
				{
					return;
				}
				_stanceState = value;
				PropertySet(this);
			}
		}

		public questCharacterState_PuppetSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
