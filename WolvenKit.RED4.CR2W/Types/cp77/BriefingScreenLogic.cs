using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BriefingScreenLogic : inkWidgetLogicController
	{
		private Vector2 _lastSizeSet;
		private CBool _isBriefingVisible;
		private wCHandle<gameJournalEntry> _briefingToOpen;
		private inkVideoWidgetReference _videoWidget;
		private inkWidgetReference _mapWidget;
		private inkWidgetReference _paperdollWidget;
		private inkWidgetReference _animatedWidget;
		private CFloat _fadeDuration;
		private CEnum<inkanimInterpolationType> _interpolationType;
		private CEnum<inkanimInterpolationMode> _interpolationMode;
		private Vector2 _minimizedSize;
		private Vector2 _maximizedSize;

		[Ordinal(1)] 
		[RED("lastSizeSet")] 
		public Vector2 LastSizeSet
		{
			get
			{
				if (_lastSizeSet == null)
				{
					_lastSizeSet = (Vector2) CR2WTypeManager.Create("Vector2", "lastSizeSet", cr2w, this);
				}
				return _lastSizeSet;
			}
			set
			{
				if (_lastSizeSet == value)
				{
					return;
				}
				_lastSizeSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isBriefingVisible")] 
		public CBool IsBriefingVisible
		{
			get
			{
				if (_isBriefingVisible == null)
				{
					_isBriefingVisible = (CBool) CR2WTypeManager.Create("Bool", "isBriefingVisible", cr2w, this);
				}
				return _isBriefingVisible;
			}
			set
			{
				if (_isBriefingVisible == value)
				{
					return;
				}
				_isBriefingVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("briefingToOpen")] 
		public wCHandle<gameJournalEntry> BriefingToOpen
		{
			get
			{
				if (_briefingToOpen == null)
				{
					_briefingToOpen = (wCHandle<gameJournalEntry>) CR2WTypeManager.Create("whandle:gameJournalEntry", "briefingToOpen", cr2w, this);
				}
				return _briefingToOpen;
			}
			set
			{
				if (_briefingToOpen == value)
				{
					return;
				}
				_briefingToOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("videoWidget")] 
		public inkVideoWidgetReference VideoWidget
		{
			get
			{
				if (_videoWidget == null)
				{
					_videoWidget = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "videoWidget", cr2w, this);
				}
				return _videoWidget;
			}
			set
			{
				if (_videoWidget == value)
				{
					return;
				}
				_videoWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("mapWidget")] 
		public inkWidgetReference MapWidget
		{
			get
			{
				if (_mapWidget == null)
				{
					_mapWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "mapWidget", cr2w, this);
				}
				return _mapWidget;
			}
			set
			{
				if (_mapWidget == value)
				{
					return;
				}
				_mapWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("paperdollWidget")] 
		public inkWidgetReference PaperdollWidget
		{
			get
			{
				if (_paperdollWidget == null)
				{
					_paperdollWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "paperdollWidget", cr2w, this);
				}
				return _paperdollWidget;
			}
			set
			{
				if (_paperdollWidget == value)
				{
					return;
				}
				_paperdollWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("animatedWidget")] 
		public inkWidgetReference AnimatedWidget
		{
			get
			{
				if (_animatedWidget == null)
				{
					_animatedWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "animatedWidget", cr2w, this);
				}
				return _animatedWidget;
			}
			set
			{
				if (_animatedWidget == value)
				{
					return;
				}
				_animatedWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("fadeDuration")] 
		public CFloat FadeDuration
		{
			get
			{
				if (_fadeDuration == null)
				{
					_fadeDuration = (CFloat) CR2WTypeManager.Create("Float", "fadeDuration", cr2w, this);
				}
				return _fadeDuration;
			}
			set
			{
				if (_fadeDuration == value)
				{
					return;
				}
				_fadeDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("InterpolationType")] 
		public CEnum<inkanimInterpolationType> InterpolationType
		{
			get
			{
				if (_interpolationType == null)
				{
					_interpolationType = (CEnum<inkanimInterpolationType>) CR2WTypeManager.Create("inkanimInterpolationType", "InterpolationType", cr2w, this);
				}
				return _interpolationType;
			}
			set
			{
				if (_interpolationType == value)
				{
					return;
				}
				_interpolationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("InterpolationMode")] 
		public CEnum<inkanimInterpolationMode> InterpolationMode
		{
			get
			{
				if (_interpolationMode == null)
				{
					_interpolationMode = (CEnum<inkanimInterpolationMode>) CR2WTypeManager.Create("inkanimInterpolationMode", "InterpolationMode", cr2w, this);
				}
				return _interpolationMode;
			}
			set
			{
				if (_interpolationMode == value)
				{
					return;
				}
				_interpolationMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("minimizedSize")] 
		public Vector2 MinimizedSize
		{
			get
			{
				if (_minimizedSize == null)
				{
					_minimizedSize = (Vector2) CR2WTypeManager.Create("Vector2", "minimizedSize", cr2w, this);
				}
				return _minimizedSize;
			}
			set
			{
				if (_minimizedSize == value)
				{
					return;
				}
				_minimizedSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("maximizedSize")] 
		public Vector2 MaximizedSize
		{
			get
			{
				if (_maximizedSize == null)
				{
					_maximizedSize = (Vector2) CR2WTypeManager.Create("Vector2", "maximizedSize", cr2w, this);
				}
				return _maximizedSize;
			}
			set
			{
				if (_maximizedSize == value)
				{
					return;
				}
				_maximizedSize = value;
				PropertySet(this);
			}
		}

		public BriefingScreenLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
