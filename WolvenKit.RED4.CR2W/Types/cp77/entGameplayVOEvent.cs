using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entGameplayVOEvent : redEvent
	{
		private CName _voContext;
		private CBool _isQuest;
		private CBool _ignoreFrustumCheck;
		private CBool _ignoreDistanceCheck;
		private CName _debugInitialContext;
		private CBool _ignoreGlobalVoLimitCheck;
		private entEntityID _answeringEntityId;
		private CEnum<locVoiceoverContext> _overridingVoiceoverContext;
		private CEnum<locVoiceoverExpression> _overridingVoiceoverExpression;
		private CBool _overrideVoiceoverExpression;
		private CUInt8 _overridingVisualStyleValue;
		private CBool _overrideVisualStyle;

		[Ordinal(0)] 
		[RED("voContext")] 
		public CName VoContext
		{
			get
			{
				if (_voContext == null)
				{
					_voContext = (CName) CR2WTypeManager.Create("CName", "voContext", cr2w, this);
				}
				return _voContext;
			}
			set
			{
				if (_voContext == value)
				{
					return;
				}
				_voContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isQuest")] 
		public CBool IsQuest
		{
			get
			{
				if (_isQuest == null)
				{
					_isQuest = (CBool) CR2WTypeManager.Create("Bool", "isQuest", cr2w, this);
				}
				return _isQuest;
			}
			set
			{
				if (_isQuest == value)
				{
					return;
				}
				_isQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ignoreFrustumCheck")] 
		public CBool IgnoreFrustumCheck
		{
			get
			{
				if (_ignoreFrustumCheck == null)
				{
					_ignoreFrustumCheck = (CBool) CR2WTypeManager.Create("Bool", "ignoreFrustumCheck", cr2w, this);
				}
				return _ignoreFrustumCheck;
			}
			set
			{
				if (_ignoreFrustumCheck == value)
				{
					return;
				}
				_ignoreFrustumCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ignoreDistanceCheck")] 
		public CBool IgnoreDistanceCheck
		{
			get
			{
				if (_ignoreDistanceCheck == null)
				{
					_ignoreDistanceCheck = (CBool) CR2WTypeManager.Create("Bool", "ignoreDistanceCheck", cr2w, this);
				}
				return _ignoreDistanceCheck;
			}
			set
			{
				if (_ignoreDistanceCheck == value)
				{
					return;
				}
				_ignoreDistanceCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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
		[RED("answeringEntityId")] 
		public entEntityID AnsweringEntityId
		{
			get
			{
				if (_answeringEntityId == null)
				{
					_answeringEntityId = (entEntityID) CR2WTypeManager.Create("entEntityID", "answeringEntityId", cr2w, this);
				}
				return _answeringEntityId;
			}
			set
			{
				if (_answeringEntityId == value)
				{
					return;
				}
				_answeringEntityId = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("overridingVoiceoverContext")] 
		public CEnum<locVoiceoverContext> OverridingVoiceoverContext
		{
			get
			{
				if (_overridingVoiceoverContext == null)
				{
					_overridingVoiceoverContext = (CEnum<locVoiceoverContext>) CR2WTypeManager.Create("locVoiceoverContext", "overridingVoiceoverContext", cr2w, this);
				}
				return _overridingVoiceoverContext;
			}
			set
			{
				if (_overridingVoiceoverContext == value)
				{
					return;
				}
				_overridingVoiceoverContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
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

		public entGameplayVOEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
