using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HudPhoneAvatarController : HUDPhoneElement
	{
		private inkImageWidgetReference _contactAvatar;
		private inkImageWidgetReference _holocallRenderTexture;
		private inkImageWidgetReference _signalRangeIcon;
		private inkTextWidgetReference _contactName;
		private inkTextWidgetReference _statusText;
		private inkCanvasWidgetReference _waveformPlaceholder;
		private inkFlexWidgetReference _holocallHolder;
		private CName _unknownAvatarName;
		private CColor _defaultPortraitColor;
		private Vector2 _defaultImageSize;
		private CName _loopAnimationName;
		private CName _showingAnimationName;
		private CName _hidingAnimationName;
		private CName _audiocallShowingAnimationName;
		private CName _audiocallHidingAnimationName;
		private CName _holocallShowingAnimationName;
		private CName _holocallHidingAnimationName;
		private CHandle<inkanimProxy> _loopAnimation;
		private inkanimPlaybackOptions _options;
		private CHandle<gameIJournalManager> _journalManager;
		private CHandle<inkanimProxy> _rootAnimation;
		private CHandle<inkanimProxy> _audiocallAnimation;
		private CHandle<inkanimProxy> _holocallAnimation;
		private inkWidgetReference _holder;
		private CHandle<inkanimDefinition> _alpha_fadein;
		private CEnum<EHudAvatarMode> _currentMode;
		private CBool _minimized;

		[Ordinal(2)] 
		[RED("ContactAvatar")] 
		public inkImageWidgetReference ContactAvatar
		{
			get
			{
				if (_contactAvatar == null)
				{
					_contactAvatar = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "ContactAvatar", cr2w, this);
				}
				return _contactAvatar;
			}
			set
			{
				if (_contactAvatar == value)
				{
					return;
				}
				_contactAvatar = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("HolocallRenderTexture")] 
		public inkImageWidgetReference HolocallRenderTexture
		{
			get
			{
				if (_holocallRenderTexture == null)
				{
					_holocallRenderTexture = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "HolocallRenderTexture", cr2w, this);
				}
				return _holocallRenderTexture;
			}
			set
			{
				if (_holocallRenderTexture == value)
				{
					return;
				}
				_holocallRenderTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("SignalRangeIcon")] 
		public inkImageWidgetReference SignalRangeIcon
		{
			get
			{
				if (_signalRangeIcon == null)
				{
					_signalRangeIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "SignalRangeIcon", cr2w, this);
				}
				return _signalRangeIcon;
			}
			set
			{
				if (_signalRangeIcon == value)
				{
					return;
				}
				_signalRangeIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ContactName")] 
		public inkTextWidgetReference ContactName
		{
			get
			{
				if (_contactName == null)
				{
					_contactName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "ContactName", cr2w, this);
				}
				return _contactName;
			}
			set
			{
				if (_contactName == value)
				{
					return;
				}
				_contactName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("StatusText")] 
		public inkTextWidgetReference StatusText
		{
			get
			{
				if (_statusText == null)
				{
					_statusText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "StatusText", cr2w, this);
				}
				return _statusText;
			}
			set
			{
				if (_statusText == value)
				{
					return;
				}
				_statusText = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("WaveformPlaceholder")] 
		public inkCanvasWidgetReference WaveformPlaceholder
		{
			get
			{
				if (_waveformPlaceholder == null)
				{
					_waveformPlaceholder = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "WaveformPlaceholder", cr2w, this);
				}
				return _waveformPlaceholder;
			}
			set
			{
				if (_waveformPlaceholder == value)
				{
					return;
				}
				_waveformPlaceholder = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("HolocallHolder")] 
		public inkFlexWidgetReference HolocallHolder
		{
			get
			{
				if (_holocallHolder == null)
				{
					_holocallHolder = (inkFlexWidgetReference) CR2WTypeManager.Create("inkFlexWidgetReference", "HolocallHolder", cr2w, this);
				}
				return _holocallHolder;
			}
			set
			{
				if (_holocallHolder == value)
				{
					return;
				}
				_holocallHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("UnknownAvatarName")] 
		public CName UnknownAvatarName
		{
			get
			{
				if (_unknownAvatarName == null)
				{
					_unknownAvatarName = (CName) CR2WTypeManager.Create("CName", "UnknownAvatarName", cr2w, this);
				}
				return _unknownAvatarName;
			}
			set
			{
				if (_unknownAvatarName == value)
				{
					return;
				}
				_unknownAvatarName = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("DefaultPortraitColor")] 
		public CColor DefaultPortraitColor
		{
			get
			{
				if (_defaultPortraitColor == null)
				{
					_defaultPortraitColor = (CColor) CR2WTypeManager.Create("Color", "DefaultPortraitColor", cr2w, this);
				}
				return _defaultPortraitColor;
			}
			set
			{
				if (_defaultPortraitColor == value)
				{
					return;
				}
				_defaultPortraitColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("DefaultImageSize")] 
		public Vector2 DefaultImageSize
		{
			get
			{
				if (_defaultImageSize == null)
				{
					_defaultImageSize = (Vector2) CR2WTypeManager.Create("Vector2", "DefaultImageSize", cr2w, this);
				}
				return _defaultImageSize;
			}
			set
			{
				if (_defaultImageSize == value)
				{
					return;
				}
				_defaultImageSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("LoopAnimationName")] 
		public CName LoopAnimationName
		{
			get
			{
				if (_loopAnimationName == null)
				{
					_loopAnimationName = (CName) CR2WTypeManager.Create("CName", "LoopAnimationName", cr2w, this);
				}
				return _loopAnimationName;
			}
			set
			{
				if (_loopAnimationName == value)
				{
					return;
				}
				_loopAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("ShowingAnimationName")] 
		public CName ShowingAnimationName
		{
			get
			{
				if (_showingAnimationName == null)
				{
					_showingAnimationName = (CName) CR2WTypeManager.Create("CName", "ShowingAnimationName", cr2w, this);
				}
				return _showingAnimationName;
			}
			set
			{
				if (_showingAnimationName == value)
				{
					return;
				}
				_showingAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("HidingAnimationName")] 
		public CName HidingAnimationName
		{
			get
			{
				if (_hidingAnimationName == null)
				{
					_hidingAnimationName = (CName) CR2WTypeManager.Create("CName", "HidingAnimationName", cr2w, this);
				}
				return _hidingAnimationName;
			}
			set
			{
				if (_hidingAnimationName == value)
				{
					return;
				}
				_hidingAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("AudiocallShowingAnimationName")] 
		public CName AudiocallShowingAnimationName
		{
			get
			{
				if (_audiocallShowingAnimationName == null)
				{
					_audiocallShowingAnimationName = (CName) CR2WTypeManager.Create("CName", "AudiocallShowingAnimationName", cr2w, this);
				}
				return _audiocallShowingAnimationName;
			}
			set
			{
				if (_audiocallShowingAnimationName == value)
				{
					return;
				}
				_audiocallShowingAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("AudiocallHidingAnimationName")] 
		public CName AudiocallHidingAnimationName
		{
			get
			{
				if (_audiocallHidingAnimationName == null)
				{
					_audiocallHidingAnimationName = (CName) CR2WTypeManager.Create("CName", "AudiocallHidingAnimationName", cr2w, this);
				}
				return _audiocallHidingAnimationName;
			}
			set
			{
				if (_audiocallHidingAnimationName == value)
				{
					return;
				}
				_audiocallHidingAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("HolocallShowingAnimationName")] 
		public CName HolocallShowingAnimationName
		{
			get
			{
				if (_holocallShowingAnimationName == null)
				{
					_holocallShowingAnimationName = (CName) CR2WTypeManager.Create("CName", "HolocallShowingAnimationName", cr2w, this);
				}
				return _holocallShowingAnimationName;
			}
			set
			{
				if (_holocallShowingAnimationName == value)
				{
					return;
				}
				_holocallShowingAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("HolocallHidingAnimationName")] 
		public CName HolocallHidingAnimationName
		{
			get
			{
				if (_holocallHidingAnimationName == null)
				{
					_holocallHidingAnimationName = (CName) CR2WTypeManager.Create("CName", "HolocallHidingAnimationName", cr2w, this);
				}
				return _holocallHidingAnimationName;
			}
			set
			{
				if (_holocallHidingAnimationName == value)
				{
					return;
				}
				_holocallHidingAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("LoopAnimation")] 
		public CHandle<inkanimProxy> LoopAnimation
		{
			get
			{
				if (_loopAnimation == null)
				{
					_loopAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "LoopAnimation", cr2w, this);
				}
				return _loopAnimation;
			}
			set
			{
				if (_loopAnimation == value)
				{
					return;
				}
				_loopAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("options")] 
		public inkanimPlaybackOptions Options
		{
			get
			{
				if (_options == null)
				{
					_options = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "options", cr2w, this);
				}
				return _options;
			}
			set
			{
				if (_options == value)
				{
					return;
				}
				_options = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("JournalManager")] 
		public CHandle<gameIJournalManager> JournalManager
		{
			get
			{
				if (_journalManager == null)
				{
					_journalManager = (CHandle<gameIJournalManager>) CR2WTypeManager.Create("handle:gameIJournalManager", "JournalManager", cr2w, this);
				}
				return _journalManager;
			}
			set
			{
				if (_journalManager == value)
				{
					return;
				}
				_journalManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("RootAnimation")] 
		public CHandle<inkanimProxy> RootAnimation
		{
			get
			{
				if (_rootAnimation == null)
				{
					_rootAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "RootAnimation", cr2w, this);
				}
				return _rootAnimation;
			}
			set
			{
				if (_rootAnimation == value)
				{
					return;
				}
				_rootAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("AudiocallAnimation")] 
		public CHandle<inkanimProxy> AudiocallAnimation
		{
			get
			{
				if (_audiocallAnimation == null)
				{
					_audiocallAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "AudiocallAnimation", cr2w, this);
				}
				return _audiocallAnimation;
			}
			set
			{
				if (_audiocallAnimation == value)
				{
					return;
				}
				_audiocallAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("HolocallAnimation")] 
		public CHandle<inkanimProxy> HolocallAnimation
		{
			get
			{
				if (_holocallAnimation == null)
				{
					_holocallAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "HolocallAnimation", cr2w, this);
				}
				return _holocallAnimation;
			}
			set
			{
				if (_holocallAnimation == value)
				{
					return;
				}
				_holocallAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("Holder")] 
		public inkWidgetReference Holder
		{
			get
			{
				if (_holder == null)
				{
					_holder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "Holder", cr2w, this);
				}
				return _holder;
			}
			set
			{
				if (_holder == value)
				{
					return;
				}
				_holder = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get
			{
				if (_alpha_fadein == null)
				{
					_alpha_fadein = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "alpha_fadein", cr2w, this);
				}
				return _alpha_fadein;
			}
			set
			{
				if (_alpha_fadein == value)
				{
					return;
				}
				_alpha_fadein = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("CurrentMode")] 
		public CEnum<EHudAvatarMode> CurrentMode
		{
			get
			{
				if (_currentMode == null)
				{
					_currentMode = (CEnum<EHudAvatarMode>) CR2WTypeManager.Create("EHudAvatarMode", "CurrentMode", cr2w, this);
				}
				return _currentMode;
			}
			set
			{
				if (_currentMode == value)
				{
					return;
				}
				_currentMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("Minimized")] 
		public CBool Minimized
		{
			get
			{
				if (_minimized == null)
				{
					_minimized = (CBool) CR2WTypeManager.Create("Bool", "Minimized", cr2w, this);
				}
				return _minimized;
			}
			set
			{
				if (_minimized == value)
				{
					return;
				}
				_minimized = value;
				PropertySet(this);
			}
		}

		public HudPhoneAvatarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
