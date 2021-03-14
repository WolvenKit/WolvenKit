using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeComponentPS : gameComponentPS
	{
		private CBool _hideInDefaultMode;
		private CBool _hideInFocusMode;
		private CBool _inactive;
		private CBool _questInactive;
		private CArray<CName> _questForcedModules;
		private CArray<CName> _questForcedMeshes;
		private CHandle<FocusForcedHighlightPersistentData> _storedHighlightData;

		[Ordinal(0)] 
		[RED("hideInDefaultMode")] 
		public CBool HideInDefaultMode
		{
			get
			{
				if (_hideInDefaultMode == null)
				{
					_hideInDefaultMode = (CBool) CR2WTypeManager.Create("Bool", "hideInDefaultMode", cr2w, this);
				}
				return _hideInDefaultMode;
			}
			set
			{
				if (_hideInDefaultMode == value)
				{
					return;
				}
				_hideInDefaultMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hideInFocusMode")] 
		public CBool HideInFocusMode
		{
			get
			{
				if (_hideInFocusMode == null)
				{
					_hideInFocusMode = (CBool) CR2WTypeManager.Create("Bool", "hideInFocusMode", cr2w, this);
				}
				return _hideInFocusMode;
			}
			set
			{
				if (_hideInFocusMode == value)
				{
					return;
				}
				_hideInFocusMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("inactive")] 
		public CBool Inactive
		{
			get
			{
				if (_inactive == null)
				{
					_inactive = (CBool) CR2WTypeManager.Create("Bool", "inactive", cr2w, this);
				}
				return _inactive;
			}
			set
			{
				if (_inactive == value)
				{
					return;
				}
				_inactive = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("questInactive")] 
		public CBool QuestInactive
		{
			get
			{
				if (_questInactive == null)
				{
					_questInactive = (CBool) CR2WTypeManager.Create("Bool", "questInactive", cr2w, this);
				}
				return _questInactive;
			}
			set
			{
				if (_questInactive == value)
				{
					return;
				}
				_questInactive = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("questForcedModules")] 
		public CArray<CName> QuestForcedModules
		{
			get
			{
				if (_questForcedModules == null)
				{
					_questForcedModules = (CArray<CName>) CR2WTypeManager.Create("array:CName", "questForcedModules", cr2w, this);
				}
				return _questForcedModules;
			}
			set
			{
				if (_questForcedModules == value)
				{
					return;
				}
				_questForcedModules = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("questForcedMeshes")] 
		public CArray<CName> QuestForcedMeshes
		{
			get
			{
				if (_questForcedMeshes == null)
				{
					_questForcedMeshes = (CArray<CName>) CR2WTypeManager.Create("array:CName", "questForcedMeshes", cr2w, this);
				}
				return _questForcedMeshes;
			}
			set
			{
				if (_questForcedMeshes == value)
				{
					return;
				}
				_questForcedMeshes = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("storedHighlightData")] 
		public CHandle<FocusForcedHighlightPersistentData> StoredHighlightData
		{
			get
			{
				if (_storedHighlightData == null)
				{
					_storedHighlightData = (CHandle<FocusForcedHighlightPersistentData>) CR2WTypeManager.Create("handle:FocusForcedHighlightPersistentData", "storedHighlightData", cr2w, this);
				}
				return _storedHighlightData;
			}
			set
			{
				if (_storedHighlightData == value)
				{
					return;
				}
				_storedHighlightData = value;
				PropertySet(this);
			}
		}

		public gameVisionModeComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
