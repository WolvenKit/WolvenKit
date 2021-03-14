using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChatterLineLogicController : BaseSubtitleLineLogicController
	{
		private inkWidgetReference _textContainer;
		private inkWidgetReference _speachBubble;
		private inkRectangleWidgetReference _background;
		private inkWidgetReference _container_normal;
		private inkWidgetReference _container_wide;
		private inkTextWidgetReference _text_normal;
		private inkTextWidgetReference _text_wide;
		private CHandle<inkTextKiroshiAnimationController> _kiroshiAnimationCtrl_Normal;
		private CHandle<inkTextKiroshiAnimationController> _kiroshiAnimationCtrl_Wide;
		private CHandle<inkTextMotherTongueController> _motherTongueCtrl_Normal;
		private CHandle<inkTextMotherTongueController> _motherTongueCtrl_Wide;
		private CBool _isNameplateVisible;
		private entEntityID _nameplateEntityId;
		private CFloat _nameplatHeightOffset;
		private entEntityID _ownerId;
		private CInt32 _c_ExtraWideTextWidth;
		private wCHandle<inkWidget> _rootWidget;
		private CHandle<inkScreenProjection> _projection;
		private CFloat _subtitlesMaxDistance;
		private CBool _limitSubtitlesDistance;

		[Ordinal(5)] 
		[RED("TextContainer")] 
		public inkWidgetReference TextContainer
		{
			get
			{
				if (_textContainer == null)
				{
					_textContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "TextContainer", cr2w, this);
				}
				return _textContainer;
			}
			set
			{
				if (_textContainer == value)
				{
					return;
				}
				_textContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("speachBubble")] 
		public inkWidgetReference SpeachBubble
		{
			get
			{
				if (_speachBubble == null)
				{
					_speachBubble = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "speachBubble", cr2w, this);
				}
				return _speachBubble;
			}
			set
			{
				if (_speachBubble == value)
				{
					return;
				}
				_speachBubble = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("background")] 
		public inkRectangleWidgetReference Background
		{
			get
			{
				if (_background == null)
				{
					_background = (inkRectangleWidgetReference) CR2WTypeManager.Create("inkRectangleWidgetReference", "background", cr2w, this);
				}
				return _background;
			}
			set
			{
				if (_background == value)
				{
					return;
				}
				_background = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("container_normal")] 
		public inkWidgetReference Container_normal
		{
			get
			{
				if (_container_normal == null)
				{
					_container_normal = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "container_normal", cr2w, this);
				}
				return _container_normal;
			}
			set
			{
				if (_container_normal == value)
				{
					return;
				}
				_container_normal = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("container_wide")] 
		public inkWidgetReference Container_wide
		{
			get
			{
				if (_container_wide == null)
				{
					_container_wide = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "container_wide", cr2w, this);
				}
				return _container_wide;
			}
			set
			{
				if (_container_wide == value)
				{
					return;
				}
				_container_wide = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("text_normal")] 
		public inkTextWidgetReference Text_normal
		{
			get
			{
				if (_text_normal == null)
				{
					_text_normal = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "text_normal", cr2w, this);
				}
				return _text_normal;
			}
			set
			{
				if (_text_normal == value)
				{
					return;
				}
				_text_normal = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("text_wide")] 
		public inkTextWidgetReference Text_wide
		{
			get
			{
				if (_text_wide == null)
				{
					_text_wide = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "text_wide", cr2w, this);
				}
				return _text_wide;
			}
			set
			{
				if (_text_wide == value)
				{
					return;
				}
				_text_wide = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("kiroshiAnimationCtrl_Normal")] 
		public CHandle<inkTextKiroshiAnimationController> KiroshiAnimationCtrl_Normal
		{
			get
			{
				if (_kiroshiAnimationCtrl_Normal == null)
				{
					_kiroshiAnimationCtrl_Normal = (CHandle<inkTextKiroshiAnimationController>) CR2WTypeManager.Create("handle:inkTextKiroshiAnimationController", "kiroshiAnimationCtrl_Normal", cr2w, this);
				}
				return _kiroshiAnimationCtrl_Normal;
			}
			set
			{
				if (_kiroshiAnimationCtrl_Normal == value)
				{
					return;
				}
				_kiroshiAnimationCtrl_Normal = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("kiroshiAnimationCtrl_Wide")] 
		public CHandle<inkTextKiroshiAnimationController> KiroshiAnimationCtrl_Wide
		{
			get
			{
				if (_kiroshiAnimationCtrl_Wide == null)
				{
					_kiroshiAnimationCtrl_Wide = (CHandle<inkTextKiroshiAnimationController>) CR2WTypeManager.Create("handle:inkTextKiroshiAnimationController", "kiroshiAnimationCtrl_Wide", cr2w, this);
				}
				return _kiroshiAnimationCtrl_Wide;
			}
			set
			{
				if (_kiroshiAnimationCtrl_Wide == value)
				{
					return;
				}
				_kiroshiAnimationCtrl_Wide = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("motherTongueCtrl_Normal")] 
		public CHandle<inkTextMotherTongueController> MotherTongueCtrl_Normal
		{
			get
			{
				if (_motherTongueCtrl_Normal == null)
				{
					_motherTongueCtrl_Normal = (CHandle<inkTextMotherTongueController>) CR2WTypeManager.Create("handle:inkTextMotherTongueController", "motherTongueCtrl_Normal", cr2w, this);
				}
				return _motherTongueCtrl_Normal;
			}
			set
			{
				if (_motherTongueCtrl_Normal == value)
				{
					return;
				}
				_motherTongueCtrl_Normal = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("motherTongueCtrl_Wide")] 
		public CHandle<inkTextMotherTongueController> MotherTongueCtrl_Wide
		{
			get
			{
				if (_motherTongueCtrl_Wide == null)
				{
					_motherTongueCtrl_Wide = (CHandle<inkTextMotherTongueController>) CR2WTypeManager.Create("handle:inkTextMotherTongueController", "motherTongueCtrl_Wide", cr2w, this);
				}
				return _motherTongueCtrl_Wide;
			}
			set
			{
				if (_motherTongueCtrl_Wide == value)
				{
					return;
				}
				_motherTongueCtrl_Wide = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("isNameplateVisible")] 
		public CBool IsNameplateVisible
		{
			get
			{
				if (_isNameplateVisible == null)
				{
					_isNameplateVisible = (CBool) CR2WTypeManager.Create("Bool", "isNameplateVisible", cr2w, this);
				}
				return _isNameplateVisible;
			}
			set
			{
				if (_isNameplateVisible == value)
				{
					return;
				}
				_isNameplateVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("nameplateEntityId")] 
		public entEntityID NameplateEntityId
		{
			get
			{
				if (_nameplateEntityId == null)
				{
					_nameplateEntityId = (entEntityID) CR2WTypeManager.Create("entEntityID", "nameplateEntityId", cr2w, this);
				}
				return _nameplateEntityId;
			}
			set
			{
				if (_nameplateEntityId == value)
				{
					return;
				}
				_nameplateEntityId = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("nameplatHeightOffset")] 
		public CFloat NameplatHeightOffset
		{
			get
			{
				if (_nameplatHeightOffset == null)
				{
					_nameplatHeightOffset = (CFloat) CR2WTypeManager.Create("Float", "nameplatHeightOffset", cr2w, this);
				}
				return _nameplatHeightOffset;
			}
			set
			{
				if (_nameplatHeightOffset == value)
				{
					return;
				}
				_nameplatHeightOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("ownerId")] 
		public entEntityID OwnerId
		{
			get
			{
				if (_ownerId == null)
				{
					_ownerId = (entEntityID) CR2WTypeManager.Create("entEntityID", "ownerId", cr2w, this);
				}
				return _ownerId;
			}
			set
			{
				if (_ownerId == value)
				{
					return;
				}
				_ownerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("c_ExtraWideTextWidth")] 
		public CInt32 C_ExtraWideTextWidth
		{
			get
			{
				if (_c_ExtraWideTextWidth == null)
				{
					_c_ExtraWideTextWidth = (CInt32) CR2WTypeManager.Create("Int32", "c_ExtraWideTextWidth", cr2w, this);
				}
				return _c_ExtraWideTextWidth;
			}
			set
			{
				if (_c_ExtraWideTextWidth == value)
				{
					return;
				}
				_c_ExtraWideTextWidth = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("projection")] 
		public CHandle<inkScreenProjection> Projection
		{
			get
			{
				if (_projection == null)
				{
					_projection = (CHandle<inkScreenProjection>) CR2WTypeManager.Create("handle:inkScreenProjection", "projection", cr2w, this);
				}
				return _projection;
			}
			set
			{
				if (_projection == value)
				{
					return;
				}
				_projection = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("subtitlesMaxDistance")] 
		public CFloat SubtitlesMaxDistance
		{
			get
			{
				if (_subtitlesMaxDistance == null)
				{
					_subtitlesMaxDistance = (CFloat) CR2WTypeManager.Create("Float", "subtitlesMaxDistance", cr2w, this);
				}
				return _subtitlesMaxDistance;
			}
			set
			{
				if (_subtitlesMaxDistance == value)
				{
					return;
				}
				_subtitlesMaxDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("limitSubtitlesDistance")] 
		public CBool LimitSubtitlesDistance
		{
			get
			{
				if (_limitSubtitlesDistance == null)
				{
					_limitSubtitlesDistance = (CBool) CR2WTypeManager.Create("Bool", "limitSubtitlesDistance", cr2w, this);
				}
				return _limitSubtitlesDistance;
			}
			set
			{
				if (_limitSubtitlesDistance == value)
				{
					return;
				}
				_limitSubtitlesDistance = value;
				PropertySet(this);
			}
		}

		public ChatterLineLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
