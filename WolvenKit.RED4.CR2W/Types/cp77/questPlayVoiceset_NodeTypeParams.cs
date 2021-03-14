using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPlayVoiceset_NodeTypeParams : CVariable
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CName _voicesetName;
		private CBool _useVoicesetSystem;
		private CBool _playOnlyGrunt;
		private CEnum<locVoiceoverContext> _overridingVoiceoverContext;
		private CBool _overrideVoiceoverExpression;
		private CEnum<locVoiceoverExpression> _overridingVoiceoverExpression;
		private CBool _overrideVisualStyle;
		private CEnum<scnDialogLineVisualStyle> _overridingVisualStyle;

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
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get
			{
				if (_isPlayer == null)
				{
					_isPlayer = (CBool) CR2WTypeManager.Create("Bool", "isPlayer", cr2w, this);
				}
				return _isPlayer;
			}
			set
			{
				if (_isPlayer == value)
				{
					return;
				}
				_isPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("voicesetName")] 
		public CName VoicesetName
		{
			get
			{
				if (_voicesetName == null)
				{
					_voicesetName = (CName) CR2WTypeManager.Create("CName", "voicesetName", cr2w, this);
				}
				return _voicesetName;
			}
			set
			{
				if (_voicesetName == value)
				{
					return;
				}
				_voicesetName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("useVoicesetSystem")] 
		public CBool UseVoicesetSystem
		{
			get
			{
				if (_useVoicesetSystem == null)
				{
					_useVoicesetSystem = (CBool) CR2WTypeManager.Create("Bool", "useVoicesetSystem", cr2w, this);
				}
				return _useVoicesetSystem;
			}
			set
			{
				if (_useVoicesetSystem == value)
				{
					return;
				}
				_useVoicesetSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("playOnlyGrunt")] 
		public CBool PlayOnlyGrunt
		{
			get
			{
				if (_playOnlyGrunt == null)
				{
					_playOnlyGrunt = (CBool) CR2WTypeManager.Create("Bool", "playOnlyGrunt", cr2w, this);
				}
				return _playOnlyGrunt;
			}
			set
			{
				if (_playOnlyGrunt == value)
				{
					return;
				}
				_playOnlyGrunt = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(9)] 
		[RED("overridingVisualStyle")] 
		public CEnum<scnDialogLineVisualStyle> OverridingVisualStyle
		{
			get
			{
				if (_overridingVisualStyle == null)
				{
					_overridingVisualStyle = (CEnum<scnDialogLineVisualStyle>) CR2WTypeManager.Create("scnDialogLineVisualStyle", "overridingVisualStyle", cr2w, this);
				}
				return _overridingVisualStyle;
			}
			set
			{
				if (_overridingVisualStyle == value)
				{
					return;
				}
				_overridingVisualStyle = value;
				PropertySet(this);
			}
		}

		public questPlayVoiceset_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
