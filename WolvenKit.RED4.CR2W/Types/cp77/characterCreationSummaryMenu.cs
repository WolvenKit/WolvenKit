using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationSummaryMenu : gameuiBaseCharacterCreationController
	{
		private inkTextWidgetReference _backstoryTitle;
		private inkImageWidgetReference _backstoryIcon;
		private inkTextWidgetReference _backstory;
		private inkTextWidgetReference _attributeBodyValue;
		private inkTextWidgetReference _attributeIntelligenceValue;
		private inkTextWidgetReference _attributeReflexesValue;
		private inkTextWidgetReference _attributeTechnicalAbilityValue;
		private inkTextWidgetReference _attributeCoolValue;
		private inkWidgetReference _previousPageBtn;
		private inkWidgetReference _glitchBtn;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<inkanimProxy> _loadingAnimationProxy;
		private CBool _loadingFinished;
		private CInt32 _glitchClicks;

		[Ordinal(6)] 
		[RED("backstoryTitle")] 
		public inkTextWidgetReference BackstoryTitle
		{
			get
			{
				if (_backstoryTitle == null)
				{
					_backstoryTitle = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "backstoryTitle", cr2w, this);
				}
				return _backstoryTitle;
			}
			set
			{
				if (_backstoryTitle == value)
				{
					return;
				}
				_backstoryTitle = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("backstoryIcon")] 
		public inkImageWidgetReference BackstoryIcon
		{
			get
			{
				if (_backstoryIcon == null)
				{
					_backstoryIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "backstoryIcon", cr2w, this);
				}
				return _backstoryIcon;
			}
			set
			{
				if (_backstoryIcon == value)
				{
					return;
				}
				_backstoryIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("backstory")] 
		public inkTextWidgetReference Backstory
		{
			get
			{
				if (_backstory == null)
				{
					_backstory = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "backstory", cr2w, this);
				}
				return _backstory;
			}
			set
			{
				if (_backstory == value)
				{
					return;
				}
				_backstory = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("attributeBodyValue")] 
		public inkTextWidgetReference AttributeBodyValue
		{
			get
			{
				if (_attributeBodyValue == null)
				{
					_attributeBodyValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "attributeBodyValue", cr2w, this);
				}
				return _attributeBodyValue;
			}
			set
			{
				if (_attributeBodyValue == value)
				{
					return;
				}
				_attributeBodyValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("attributeIntelligenceValue")] 
		public inkTextWidgetReference AttributeIntelligenceValue
		{
			get
			{
				if (_attributeIntelligenceValue == null)
				{
					_attributeIntelligenceValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "attributeIntelligenceValue", cr2w, this);
				}
				return _attributeIntelligenceValue;
			}
			set
			{
				if (_attributeIntelligenceValue == value)
				{
					return;
				}
				_attributeIntelligenceValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("attributeReflexesValue")] 
		public inkTextWidgetReference AttributeReflexesValue
		{
			get
			{
				if (_attributeReflexesValue == null)
				{
					_attributeReflexesValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "attributeReflexesValue", cr2w, this);
				}
				return _attributeReflexesValue;
			}
			set
			{
				if (_attributeReflexesValue == value)
				{
					return;
				}
				_attributeReflexesValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("attributeTechnicalAbilityValue")] 
		public inkTextWidgetReference AttributeTechnicalAbilityValue
		{
			get
			{
				if (_attributeTechnicalAbilityValue == null)
				{
					_attributeTechnicalAbilityValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "attributeTechnicalAbilityValue", cr2w, this);
				}
				return _attributeTechnicalAbilityValue;
			}
			set
			{
				if (_attributeTechnicalAbilityValue == value)
				{
					return;
				}
				_attributeTechnicalAbilityValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("attributeCoolValue")] 
		public inkTextWidgetReference AttributeCoolValue
		{
			get
			{
				if (_attributeCoolValue == null)
				{
					_attributeCoolValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "attributeCoolValue", cr2w, this);
				}
				return _attributeCoolValue;
			}
			set
			{
				if (_attributeCoolValue == value)
				{
					return;
				}
				_attributeCoolValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("previousPageBtn")] 
		public inkWidgetReference PreviousPageBtn
		{
			get
			{
				if (_previousPageBtn == null)
				{
					_previousPageBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "previousPageBtn", cr2w, this);
				}
				return _previousPageBtn;
			}
			set
			{
				if (_previousPageBtn == value)
				{
					return;
				}
				_previousPageBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("glitchBtn")] 
		public inkWidgetReference GlitchBtn
		{
			get
			{
				if (_glitchBtn == null)
				{
					_glitchBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "glitchBtn", cr2w, this);
				}
				return _glitchBtn;
			}
			set
			{
				if (_glitchBtn == value)
				{
					return;
				}
				_glitchBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
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

		[Ordinal(17)] 
		[RED("loadingAnimationProxy")] 
		public CHandle<inkanimProxy> LoadingAnimationProxy
		{
			get
			{
				if (_loadingAnimationProxy == null)
				{
					_loadingAnimationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "loadingAnimationProxy", cr2w, this);
				}
				return _loadingAnimationProxy;
			}
			set
			{
				if (_loadingAnimationProxy == value)
				{
					return;
				}
				_loadingAnimationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("loadingFinished")] 
		public CBool LoadingFinished
		{
			get
			{
				if (_loadingFinished == null)
				{
					_loadingFinished = (CBool) CR2WTypeManager.Create("Bool", "loadingFinished", cr2w, this);
				}
				return _loadingFinished;
			}
			set
			{
				if (_loadingFinished == value)
				{
					return;
				}
				_loadingFinished = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("glitchClicks")] 
		public CInt32 GlitchClicks
		{
			get
			{
				if (_glitchClicks == null)
				{
					_glitchClicks = (CInt32) CR2WTypeManager.Create("Int32", "glitchClicks", cr2w, this);
				}
				return _glitchClicks;
			}
			set
			{
				if (_glitchClicks == value)
				{
					return;
				}
				_glitchClicks = value;
				PropertySet(this);
			}
		}

		public characterCreationSummaryMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
