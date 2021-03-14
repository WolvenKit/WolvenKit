using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ObjectiveController : inkButtonController
	{
		private inkTextWidgetReference _objectiveLabel;
		private inkTextWidgetReference _objectiveStatus;
		private inkImageWidgetReference _questIcon;
		private inkImageWidgetReference _trackedIcon;
		private inkImageWidgetReference _frameBackground_On;
		private inkImageWidgetReference _frameBackground_Off;
		private inkImageWidgetReference _frameFluff_On;
		private inkImageWidgetReference _frameFluff_Off;
		private inkImageWidgetReference _folder_On;
		private inkImageWidgetReference _folder_Off;
		private CHandle<ABaseQuestObjectiveWrapper> _questObjectiveData;
		private wCHandle<ABaseQuestObjectiveWrapper> _toTrack;

		[Ordinal(10)] 
		[RED("ObjectiveLabel")] 
		public inkTextWidgetReference ObjectiveLabel
		{
			get
			{
				if (_objectiveLabel == null)
				{
					_objectiveLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "ObjectiveLabel", cr2w, this);
				}
				return _objectiveLabel;
			}
			set
			{
				if (_objectiveLabel == value)
				{
					return;
				}
				_objectiveLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("ObjectiveStatus")] 
		public inkTextWidgetReference ObjectiveStatus
		{
			get
			{
				if (_objectiveStatus == null)
				{
					_objectiveStatus = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "ObjectiveStatus", cr2w, this);
				}
				return _objectiveStatus;
			}
			set
			{
				if (_objectiveStatus == value)
				{
					return;
				}
				_objectiveStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("QuestIcon")] 
		public inkImageWidgetReference QuestIcon
		{
			get
			{
				if (_questIcon == null)
				{
					_questIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "QuestIcon", cr2w, this);
				}
				return _questIcon;
			}
			set
			{
				if (_questIcon == value)
				{
					return;
				}
				_questIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("TrackedIcon")] 
		public inkImageWidgetReference TrackedIcon
		{
			get
			{
				if (_trackedIcon == null)
				{
					_trackedIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "TrackedIcon", cr2w, this);
				}
				return _trackedIcon;
			}
			set
			{
				if (_trackedIcon == value)
				{
					return;
				}
				_trackedIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("FrameBackground_On")] 
		public inkImageWidgetReference FrameBackground_On
		{
			get
			{
				if (_frameBackground_On == null)
				{
					_frameBackground_On = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "FrameBackground_On", cr2w, this);
				}
				return _frameBackground_On;
			}
			set
			{
				if (_frameBackground_On == value)
				{
					return;
				}
				_frameBackground_On = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("FrameBackground_Off")] 
		public inkImageWidgetReference FrameBackground_Off
		{
			get
			{
				if (_frameBackground_Off == null)
				{
					_frameBackground_Off = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "FrameBackground_Off", cr2w, this);
				}
				return _frameBackground_Off;
			}
			set
			{
				if (_frameBackground_Off == value)
				{
					return;
				}
				_frameBackground_Off = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("FrameFluff_On")] 
		public inkImageWidgetReference FrameFluff_On
		{
			get
			{
				if (_frameFluff_On == null)
				{
					_frameFluff_On = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "FrameFluff_On", cr2w, this);
				}
				return _frameFluff_On;
			}
			set
			{
				if (_frameFluff_On == value)
				{
					return;
				}
				_frameFluff_On = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("FrameFluff_Off")] 
		public inkImageWidgetReference FrameFluff_Off
		{
			get
			{
				if (_frameFluff_Off == null)
				{
					_frameFluff_Off = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "FrameFluff_Off", cr2w, this);
				}
				return _frameFluff_Off;
			}
			set
			{
				if (_frameFluff_Off == value)
				{
					return;
				}
				_frameFluff_Off = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("Folder_On")] 
		public inkImageWidgetReference Folder_On
		{
			get
			{
				if (_folder_On == null)
				{
					_folder_On = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "Folder_On", cr2w, this);
				}
				return _folder_On;
			}
			set
			{
				if (_folder_On == value)
				{
					return;
				}
				_folder_On = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("Folder_Off")] 
		public inkImageWidgetReference Folder_Off
		{
			get
			{
				if (_folder_Off == null)
				{
					_folder_Off = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "Folder_Off", cr2w, this);
				}
				return _folder_Off;
			}
			set
			{
				if (_folder_Off == value)
				{
					return;
				}
				_folder_Off = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("QuestObjectiveData")] 
		public CHandle<ABaseQuestObjectiveWrapper> QuestObjectiveData
		{
			get
			{
				if (_questObjectiveData == null)
				{
					_questObjectiveData = (CHandle<ABaseQuestObjectiveWrapper>) CR2WTypeManager.Create("handle:ABaseQuestObjectiveWrapper", "QuestObjectiveData", cr2w, this);
				}
				return _questObjectiveData;
			}
			set
			{
				if (_questObjectiveData == value)
				{
					return;
				}
				_questObjectiveData = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("ToTrack")] 
		public wCHandle<ABaseQuestObjectiveWrapper> ToTrack
		{
			get
			{
				if (_toTrack == null)
				{
					_toTrack = (wCHandle<ABaseQuestObjectiveWrapper>) CR2WTypeManager.Create("whandle:ABaseQuestObjectiveWrapper", "ToTrack", cr2w, this);
				}
				return _toTrack;
			}
			set
			{
				if (_toTrack == value)
				{
					return;
				}
				_toTrack = value;
				PropertySet(this);
			}
		}

		public ObjectiveController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
