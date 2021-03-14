using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entTriggerVOEvent : redEvent
	{
		private CName _triggerBaseName;
		private CUInt32 _triggerVariationIndex;
		private CUInt32 _triggerVariationNumber;
		private CName _debugInitialContext;
		private CUInt64 _answeringEntityIDHash;
		private CBool _ignoreGlobalVoLimitCheck;
		private CEnum<locVoiceoverContext> _overridingVoContext;
		private CEnum<locVoiceoverExpression> _overridingVoiceoverExpression;
		private CBool _overrideVoiceoverExpression;
		private CUInt8 _overridingVisualStyleValue;
		private CBool _overrideVisualStyle;

		[Ordinal(0)] 
		[RED("triggerBaseName")] 
		public CName TriggerBaseName
		{
			get
			{
				if (_triggerBaseName == null)
				{
					_triggerBaseName = (CName) CR2WTypeManager.Create("CName", "triggerBaseName", cr2w, this);
				}
				return _triggerBaseName;
			}
			set
			{
				if (_triggerBaseName == value)
				{
					return;
				}
				_triggerBaseName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("triggerVariationIndex")] 
		public CUInt32 TriggerVariationIndex
		{
			get
			{
				if (_triggerVariationIndex == null)
				{
					_triggerVariationIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "triggerVariationIndex", cr2w, this);
				}
				return _triggerVariationIndex;
			}
			set
			{
				if (_triggerVariationIndex == value)
				{
					return;
				}
				_triggerVariationIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("triggerVariationNumber")] 
		public CUInt32 TriggerVariationNumber
		{
			get
			{
				if (_triggerVariationNumber == null)
				{
					_triggerVariationNumber = (CUInt32) CR2WTypeManager.Create("Uint32", "triggerVariationNumber", cr2w, this);
				}
				return _triggerVariationNumber;
			}
			set
			{
				if (_triggerVariationNumber == value)
				{
					return;
				}
				_triggerVariationNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("debugInitialContext")] 
		public CName DebugInitialContext
		{
			get
			{
				if (_debugInitialContext == null)
				{
					_debugInitialContext = (CName) CR2WTypeManager.Create("CName", "debugInitialContext", cr2w, this);
				}
				return _debugInitialContext;
			}
			set
			{
				if (_debugInitialContext == value)
				{
					return;
				}
				_debugInitialContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("answeringEntityIDHash")] 
		public CUInt64 AnsweringEntityIDHash
		{
			get
			{
				if (_answeringEntityIDHash == null)
				{
					_answeringEntityIDHash = (CUInt64) CR2WTypeManager.Create("Uint64", "answeringEntityIDHash", cr2w, this);
				}
				return _answeringEntityIDHash;
			}
			set
			{
				if (_answeringEntityIDHash == value)
				{
					return;
				}
				_answeringEntityIDHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ignoreGlobalVoLimitCheck")] 
		public CBool IgnoreGlobalVoLimitCheck
		{
			get
			{
				if (_ignoreGlobalVoLimitCheck == null)
				{
					_ignoreGlobalVoLimitCheck = (CBool) CR2WTypeManager.Create("Bool", "ignoreGlobalVoLimitCheck", cr2w, this);
				}
				return _ignoreGlobalVoLimitCheck;
			}
			set
			{
				if (_ignoreGlobalVoLimitCheck == value)
				{
					return;
				}
				_ignoreGlobalVoLimitCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("overridingVoContext")] 
		public CEnum<locVoiceoverContext> OverridingVoContext
		{
			get
			{
				if (_overridingVoContext == null)
				{
					_overridingVoContext = (CEnum<locVoiceoverContext>) CR2WTypeManager.Create("locVoiceoverContext", "overridingVoContext", cr2w, this);
				}
				return _overridingVoContext;
			}
			set
			{
				if (_overridingVoContext == value)
				{
					return;
				}
				_overridingVoContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("overridingVoiceoverExpression")] 
		public CEnum<locVoiceoverExpression> OverridingVoiceoverExpression
		{
			get
			{
				if (_overridingVoiceoverExpression == null)
				{
					_overridingVoiceoverExpression = (CEnum<locVoiceoverExpression>) CR2WTypeManager.Create("locVoiceoverExpression", "overridingVoiceoverExpression", cr2w, this);
				}
				return _overridingVoiceoverExpression;
			}
			set
			{
				if (_overridingVoiceoverExpression == value)
				{
					return;
				}
				_overridingVoiceoverExpression = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("overrideVoiceoverExpression")] 
		public CBool OverrideVoiceoverExpression
		{
			get
			{
				if (_overrideVoiceoverExpression == null)
				{
					_overrideVoiceoverExpression = (CBool) CR2WTypeManager.Create("Bool", "overrideVoiceoverExpression", cr2w, this);
				}
				return _overrideVoiceoverExpression;
			}
			set
			{
				if (_overrideVoiceoverExpression == value)
				{
					return;
				}
				_overrideVoiceoverExpression = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("overridingVisualStyleValue")] 
		public CUInt8 OverridingVisualStyleValue
		{
			get
			{
				if (_overridingVisualStyleValue == null)
				{
					_overridingVisualStyleValue = (CUInt8) CR2WTypeManager.Create("Uint8", "overridingVisualStyleValue", cr2w, this);
				}
				return _overridingVisualStyleValue;
			}
			set
			{
				if (_overridingVisualStyleValue == value)
				{
					return;
				}
				_overridingVisualStyleValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("overrideVisualStyle")] 
		public CBool OverrideVisualStyle
		{
			get
			{
				if (_overrideVisualStyle == null)
				{
					_overrideVisualStyle = (CBool) CR2WTypeManager.Create("Bool", "overrideVisualStyle", cr2w, this);
				}
				return _overrideVisualStyle;
			}
			set
			{
				if (_overrideVisualStyle == value)
				{
					return;
				}
				_overrideVisualStyle = value;
				PropertySet(this);
			}
		}

		public entTriggerVOEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
