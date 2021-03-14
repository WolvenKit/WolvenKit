using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSceneNodeDefinition : questSignalStoppingNodeDefinition
	{
		private raRef<scnSceneResource> _sceneFile;
		private scnWorldMarker _sceneLocation;
		private CArray<CHandle<scnIInterruptionOperation>> _interruptionOperations;
		private CBool _syncToMusic;
		private CBool _notAllowedToBeFrozen;
		private CBool _reapplyInterruptionOperationsAfterGameLoad;

		[Ordinal(2)] 
		[RED("sceneFile")] 
		public raRef<scnSceneResource> SceneFile
		{
			get
			{
				if (_sceneFile == null)
				{
					_sceneFile = (raRef<scnSceneResource>) CR2WTypeManager.Create("raRef:scnSceneResource", "sceneFile", cr2w, this);
				}
				return _sceneFile;
			}
			set
			{
				if (_sceneFile == value)
				{
					return;
				}
				_sceneFile = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("sceneLocation")] 
		public scnWorldMarker SceneLocation
		{
			get
			{
				if (_sceneLocation == null)
				{
					_sceneLocation = (scnWorldMarker) CR2WTypeManager.Create("scnWorldMarker", "sceneLocation", cr2w, this);
				}
				return _sceneLocation;
			}
			set
			{
				if (_sceneLocation == value)
				{
					return;
				}
				_sceneLocation = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("interruptionOperations")] 
		public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations
		{
			get
			{
				if (_interruptionOperations == null)
				{
					_interruptionOperations = (CArray<CHandle<scnIInterruptionOperation>>) CR2WTypeManager.Create("array:handle:scnIInterruptionOperation", "interruptionOperations", cr2w, this);
				}
				return _interruptionOperations;
			}
			set
			{
				if (_interruptionOperations == value)
				{
					return;
				}
				_interruptionOperations = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("syncToMusic")] 
		public CBool SyncToMusic
		{
			get
			{
				if (_syncToMusic == null)
				{
					_syncToMusic = (CBool) CR2WTypeManager.Create("Bool", "syncToMusic", cr2w, this);
				}
				return _syncToMusic;
			}
			set
			{
				if (_syncToMusic == value)
				{
					return;
				}
				_syncToMusic = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("notAllowedToBeFrozen")] 
		public CBool NotAllowedToBeFrozen
		{
			get
			{
				if (_notAllowedToBeFrozen == null)
				{
					_notAllowedToBeFrozen = (CBool) CR2WTypeManager.Create("Bool", "notAllowedToBeFrozen", cr2w, this);
				}
				return _notAllowedToBeFrozen;
			}
			set
			{
				if (_notAllowedToBeFrozen == value)
				{
					return;
				}
				_notAllowedToBeFrozen = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("reapplyInterruptionOperationsAfterGameLoad")] 
		public CBool ReapplyInterruptionOperationsAfterGameLoad
		{
			get
			{
				if (_reapplyInterruptionOperationsAfterGameLoad == null)
				{
					_reapplyInterruptionOperationsAfterGameLoad = (CBool) CR2WTypeManager.Create("Bool", "reapplyInterruptionOperationsAfterGameLoad", cr2w, this);
				}
				return _reapplyInterruptionOperationsAfterGameLoad;
			}
			set
			{
				if (_reapplyInterruptionOperationsAfterGameLoad == value)
				{
					return;
				}
				_reapplyInterruptionOperationsAfterGameLoad = value;
				PropertySet(this);
			}
		}

		public questSceneNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
