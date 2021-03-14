using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldMapTooltipController : WorldMapTooltipBaseController
	{
		private inkTextWidgetReference _titleText;
		private inkTextWidgetReference _descText;
		private inkWidgetReference _trackedQuestContainer;
		private inkWidgetReference _requiredLevelCanvas;
		private inkTextWidgetReference _requiredLevelText;
		private inkTextWidgetReference _requiredLevelValue;
		private inkCompoundWidgetReference _inputSetWaypointContainer;
		private inkTextWidgetReference _inputSetWaypointText;
		private inkCompoundWidgetReference _inputTrackQuestContainer;
		private inkTextWidgetReference _inputTrackQuestText;
		private inkCompoundWidgetReference _inputInteractContainer;
		private inkTextWidgetReference _inputInteractText;
		private inkCompoundWidgetReference _inputOpenJournalContainer;
		private inkTextWidgetReference _inputOpenJournalText;
		private inkCompoundWidgetReference _inputZoomToContainer;
		private inkTextWidgetReference _inputZoomToText;
		private inkTextWidgetReference _threatLevelCaption;
		private inkTextWidgetReference _threatLevelValue;
		private inkCompoundWidgetReference _collectionCountContainer;
		private inkTextWidgetReference _collectionCountText;

		[Ordinal(5)] 
		[RED("titleText")] 
		public inkTextWidgetReference TitleText
		{
			get
			{
				if (_titleText == null)
				{
					_titleText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "titleText", cr2w, this);
				}
				return _titleText;
			}
			set
			{
				if (_titleText == value)
				{
					return;
				}
				_titleText = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("descText")] 
		public inkTextWidgetReference DescText
		{
			get
			{
				if (_descText == null)
				{
					_descText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "descText", cr2w, this);
				}
				return _descText;
			}
			set
			{
				if (_descText == value)
				{
					return;
				}
				_descText = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("trackedQuestContainer")] 
		public inkWidgetReference TrackedQuestContainer
		{
			get
			{
				if (_trackedQuestContainer == null)
				{
					_trackedQuestContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "trackedQuestContainer", cr2w, this);
				}
				return _trackedQuestContainer;
			}
			set
			{
				if (_trackedQuestContainer == value)
				{
					return;
				}
				_trackedQuestContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("requiredLevelCanvas")] 
		public inkWidgetReference RequiredLevelCanvas
		{
			get
			{
				if (_requiredLevelCanvas == null)
				{
					_requiredLevelCanvas = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "requiredLevelCanvas", cr2w, this);
				}
				return _requiredLevelCanvas;
			}
			set
			{
				if (_requiredLevelCanvas == value)
				{
					return;
				}
				_requiredLevelCanvas = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("requiredLevelText")] 
		public inkTextWidgetReference RequiredLevelText
		{
			get
			{
				if (_requiredLevelText == null)
				{
					_requiredLevelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "requiredLevelText", cr2w, this);
				}
				return _requiredLevelText;
			}
			set
			{
				if (_requiredLevelText == value)
				{
					return;
				}
				_requiredLevelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("requiredLevelValue")] 
		public inkTextWidgetReference RequiredLevelValue
		{
			get
			{
				if (_requiredLevelValue == null)
				{
					_requiredLevelValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "requiredLevelValue", cr2w, this);
				}
				return _requiredLevelValue;
			}
			set
			{
				if (_requiredLevelValue == value)
				{
					return;
				}
				_requiredLevelValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("inputSetWaypointContainer")] 
		public inkCompoundWidgetReference InputSetWaypointContainer
		{
			get
			{
				if (_inputSetWaypointContainer == null)
				{
					_inputSetWaypointContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "inputSetWaypointContainer", cr2w, this);
				}
				return _inputSetWaypointContainer;
			}
			set
			{
				if (_inputSetWaypointContainer == value)
				{
					return;
				}
				_inputSetWaypointContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("inputSetWaypointText")] 
		public inkTextWidgetReference InputSetWaypointText
		{
			get
			{
				if (_inputSetWaypointText == null)
				{
					_inputSetWaypointText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "inputSetWaypointText", cr2w, this);
				}
				return _inputSetWaypointText;
			}
			set
			{
				if (_inputSetWaypointText == value)
				{
					return;
				}
				_inputSetWaypointText = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("inputTrackQuestContainer")] 
		public inkCompoundWidgetReference InputTrackQuestContainer
		{
			get
			{
				if (_inputTrackQuestContainer == null)
				{
					_inputTrackQuestContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "inputTrackQuestContainer", cr2w, this);
				}
				return _inputTrackQuestContainer;
			}
			set
			{
				if (_inputTrackQuestContainer == value)
				{
					return;
				}
				_inputTrackQuestContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("inputTrackQuestText")] 
		public inkTextWidgetReference InputTrackQuestText
		{
			get
			{
				if (_inputTrackQuestText == null)
				{
					_inputTrackQuestText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "inputTrackQuestText", cr2w, this);
				}
				return _inputTrackQuestText;
			}
			set
			{
				if (_inputTrackQuestText == value)
				{
					return;
				}
				_inputTrackQuestText = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("inputInteractContainer")] 
		public inkCompoundWidgetReference InputInteractContainer
		{
			get
			{
				if (_inputInteractContainer == null)
				{
					_inputInteractContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "inputInteractContainer", cr2w, this);
				}
				return _inputInteractContainer;
			}
			set
			{
				if (_inputInteractContainer == value)
				{
					return;
				}
				_inputInteractContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("inputInteractText")] 
		public inkTextWidgetReference InputInteractText
		{
			get
			{
				if (_inputInteractText == null)
				{
					_inputInteractText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "inputInteractText", cr2w, this);
				}
				return _inputInteractText;
			}
			set
			{
				if (_inputInteractText == value)
				{
					return;
				}
				_inputInteractText = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("inputOpenJournalContainer")] 
		public inkCompoundWidgetReference InputOpenJournalContainer
		{
			get
			{
				if (_inputOpenJournalContainer == null)
				{
					_inputOpenJournalContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "inputOpenJournalContainer", cr2w, this);
				}
				return _inputOpenJournalContainer;
			}
			set
			{
				if (_inputOpenJournalContainer == value)
				{
					return;
				}
				_inputOpenJournalContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("inputOpenJournalText")] 
		public inkTextWidgetReference InputOpenJournalText
		{
			get
			{
				if (_inputOpenJournalText == null)
				{
					_inputOpenJournalText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "inputOpenJournalText", cr2w, this);
				}
				return _inputOpenJournalText;
			}
			set
			{
				if (_inputOpenJournalText == value)
				{
					return;
				}
				_inputOpenJournalText = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("inputZoomToContainer")] 
		public inkCompoundWidgetReference InputZoomToContainer
		{
			get
			{
				if (_inputZoomToContainer == null)
				{
					_inputZoomToContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "inputZoomToContainer", cr2w, this);
				}
				return _inputZoomToContainer;
			}
			set
			{
				if (_inputZoomToContainer == value)
				{
					return;
				}
				_inputZoomToContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("inputZoomToText")] 
		public inkTextWidgetReference InputZoomToText
		{
			get
			{
				if (_inputZoomToText == null)
				{
					_inputZoomToText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "inputZoomToText", cr2w, this);
				}
				return _inputZoomToText;
			}
			set
			{
				if (_inputZoomToText == value)
				{
					return;
				}
				_inputZoomToText = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("threatLevelCaption")] 
		public inkTextWidgetReference ThreatLevelCaption
		{
			get
			{
				if (_threatLevelCaption == null)
				{
					_threatLevelCaption = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "threatLevelCaption", cr2w, this);
				}
				return _threatLevelCaption;
			}
			set
			{
				if (_threatLevelCaption == value)
				{
					return;
				}
				_threatLevelCaption = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("threatLevelValue")] 
		public inkTextWidgetReference ThreatLevelValue
		{
			get
			{
				if (_threatLevelValue == null)
				{
					_threatLevelValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "threatLevelValue", cr2w, this);
				}
				return _threatLevelValue;
			}
			set
			{
				if (_threatLevelValue == value)
				{
					return;
				}
				_threatLevelValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("collectionCountContainer")] 
		public inkCompoundWidgetReference CollectionCountContainer
		{
			get
			{
				if (_collectionCountContainer == null)
				{
					_collectionCountContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "collectionCountContainer", cr2w, this);
				}
				return _collectionCountContainer;
			}
			set
			{
				if (_collectionCountContainer == value)
				{
					return;
				}
				_collectionCountContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("collectionCountText")] 
		public inkTextWidgetReference CollectionCountText
		{
			get
			{
				if (_collectionCountText == null)
				{
					_collectionCountText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "collectionCountText", cr2w, this);
				}
				return _collectionCountText;
			}
			set
			{
				if (_collectionCountText == value)
				{
					return;
				}
				_collectionCountText = value;
				PropertySet(this);
			}
		}

		public WorldMapTooltipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
