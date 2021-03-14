using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DifficultySelectionMenu : gameuiBaseCharacterCreationController
	{
		private inkTextWidgetReference _difficultyTitle;
		private inkImageWidgetReference _difficultyIcon;
		private inkWidgetReference _difficulty0;
		private inkWidgetReference _difficulty1;
		private inkWidgetReference _difficulty2;
		private inkWidgetReference _difficulty3;
		private CHandle<inkanimProxy> _animationProxy;
		private redResourceReferenceScriptToken _c_atlas1;
		private redResourceReferenceScriptToken _c_atlas2;
		private CHandle<inkTextReplaceAnimationController> _translationAnimationCtrl;
		private CString _localizedText;

		[Ordinal(6)] 
		[RED("difficultyTitle")] 
		public inkTextWidgetReference DifficultyTitle
		{
			get
			{
				if (_difficultyTitle == null)
				{
					_difficultyTitle = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "difficultyTitle", cr2w, this);
				}
				return _difficultyTitle;
			}
			set
			{
				if (_difficultyTitle == value)
				{
					return;
				}
				_difficultyTitle = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("difficultyIcon")] 
		public inkImageWidgetReference DifficultyIcon
		{
			get
			{
				if (_difficultyIcon == null)
				{
					_difficultyIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "difficultyIcon", cr2w, this);
				}
				return _difficultyIcon;
			}
			set
			{
				if (_difficultyIcon == value)
				{
					return;
				}
				_difficultyIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("difficulty0")] 
		public inkWidgetReference Difficulty0
		{
			get
			{
				if (_difficulty0 == null)
				{
					_difficulty0 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "difficulty0", cr2w, this);
				}
				return _difficulty0;
			}
			set
			{
				if (_difficulty0 == value)
				{
					return;
				}
				_difficulty0 = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("difficulty1")] 
		public inkWidgetReference Difficulty1
		{
			get
			{
				if (_difficulty1 == null)
				{
					_difficulty1 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "difficulty1", cr2w, this);
				}
				return _difficulty1;
			}
			set
			{
				if (_difficulty1 == value)
				{
					return;
				}
				_difficulty1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("difficulty2")] 
		public inkWidgetReference Difficulty2
		{
			get
			{
				if (_difficulty2 == null)
				{
					_difficulty2 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "difficulty2", cr2w, this);
				}
				return _difficulty2;
			}
			set
			{
				if (_difficulty2 == value)
				{
					return;
				}
				_difficulty2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("difficulty3")] 
		public inkWidgetReference Difficulty3
		{
			get
			{
				if (_difficulty3 == null)
				{
					_difficulty3 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "difficulty3", cr2w, this);
				}
				return _difficulty3;
			}
			set
			{
				if (_difficulty3 == value)
				{
					return;
				}
				_difficulty3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get
			{
				if (_animationProxy == null)
				{
					_animationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animationProxy", cr2w, this);
				}
				return _animationProxy;
			}
			set
			{
				if (_animationProxy == value)
				{
					return;
				}
				_animationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("c_atlas1")] 
		public redResourceReferenceScriptToken C_atlas1
		{
			get
			{
				if (_c_atlas1 == null)
				{
					_c_atlas1 = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "c_atlas1", cr2w, this);
				}
				return _c_atlas1;
			}
			set
			{
				if (_c_atlas1 == value)
				{
					return;
				}
				_c_atlas1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("c_atlas2")] 
		public redResourceReferenceScriptToken C_atlas2
		{
			get
			{
				if (_c_atlas2 == null)
				{
					_c_atlas2 = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "c_atlas2", cr2w, this);
				}
				return _c_atlas2;
			}
			set
			{
				if (_c_atlas2 == value)
				{
					return;
				}
				_c_atlas2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("translationAnimationCtrl")] 
		public CHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl
		{
			get
			{
				if (_translationAnimationCtrl == null)
				{
					_translationAnimationCtrl = (CHandle<inkTextReplaceAnimationController>) CR2WTypeManager.Create("handle:inkTextReplaceAnimationController", "translationAnimationCtrl", cr2w, this);
				}
				return _translationAnimationCtrl;
			}
			set
			{
				if (_translationAnimationCtrl == value)
				{
					return;
				}
				_translationAnimationCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("localizedText")] 
		public CString LocalizedText
		{
			get
			{
				if (_localizedText == null)
				{
					_localizedText = (CString) CR2WTypeManager.Create("String", "localizedText", cr2w, this);
				}
				return _localizedText;
			}
			set
			{
				if (_localizedText == value)
				{
					return;
				}
				_localizedText = value;
				PropertySet(this);
			}
		}

		public DifficultySelectionMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
