using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExplosiveTriggerDevice : ExplosiveDevice
	{
		private CHandle<entMeshComponent> _meshTrigger;
		private CHandle<gameStaticTriggerAreaComponent> _trapTrigger;
		private CName _triggerName;
		private CHandle<gameStaticTriggerAreaComponent> _surroundingArea;
		private CName _surroundingAreaName;
		private CBool _soundIsActive;
		private CBool _playerIsInSurroundingArea;
		private gameDelayID _proximityExplosionEventID;
		private CBool _proximityExplosionEventSent;

		[Ordinal(116)] 
		[RED("meshTrigger")] 
		public CHandle<entMeshComponent> MeshTrigger
		{
			get
			{
				if (_meshTrigger == null)
				{
					_meshTrigger = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "meshTrigger", cr2w, this);
				}
				return _meshTrigger;
			}
			set
			{
				if (_meshTrigger == value)
				{
					return;
				}
				_meshTrigger = value;
				PropertySet(this);
			}
		}

		[Ordinal(117)] 
		[RED("trapTrigger")] 
		public CHandle<gameStaticTriggerAreaComponent> TrapTrigger
		{
			get
			{
				if (_trapTrigger == null)
				{
					_trapTrigger = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "trapTrigger", cr2w, this);
				}
				return _trapTrigger;
			}
			set
			{
				if (_trapTrigger == value)
				{
					return;
				}
				_trapTrigger = value;
				PropertySet(this);
			}
		}

		[Ordinal(118)] 
		[RED("triggerName")] 
		public CName TriggerName
		{
			get
			{
				if (_triggerName == null)
				{
					_triggerName = (CName) CR2WTypeManager.Create("CName", "triggerName", cr2w, this);
				}
				return _triggerName;
			}
			set
			{
				if (_triggerName == value)
				{
					return;
				}
				_triggerName = value;
				PropertySet(this);
			}
		}

		[Ordinal(119)] 
		[RED("surroundingArea")] 
		public CHandle<gameStaticTriggerAreaComponent> SurroundingArea
		{
			get
			{
				if (_surroundingArea == null)
				{
					_surroundingArea = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "surroundingArea", cr2w, this);
				}
				return _surroundingArea;
			}
			set
			{
				if (_surroundingArea == value)
				{
					return;
				}
				_surroundingArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(120)] 
		[RED("surroundingAreaName")] 
		public CName SurroundingAreaName
		{
			get
			{
				if (_surroundingAreaName == null)
				{
					_surroundingAreaName = (CName) CR2WTypeManager.Create("CName", "surroundingAreaName", cr2w, this);
				}
				return _surroundingAreaName;
			}
			set
			{
				if (_surroundingAreaName == value)
				{
					return;
				}
				_surroundingAreaName = value;
				PropertySet(this);
			}
		}

		[Ordinal(121)] 
		[RED("soundIsActive")] 
		public CBool SoundIsActive
		{
			get
			{
				if (_soundIsActive == null)
				{
					_soundIsActive = (CBool) CR2WTypeManager.Create("Bool", "soundIsActive", cr2w, this);
				}
				return _soundIsActive;
			}
			set
			{
				if (_soundIsActive == value)
				{
					return;
				}
				_soundIsActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(122)] 
		[RED("playerIsInSurroundingArea")] 
		public CBool PlayerIsInSurroundingArea
		{
			get
			{
				if (_playerIsInSurroundingArea == null)
				{
					_playerIsInSurroundingArea = (CBool) CR2WTypeManager.Create("Bool", "playerIsInSurroundingArea", cr2w, this);
				}
				return _playerIsInSurroundingArea;
			}
			set
			{
				if (_playerIsInSurroundingArea == value)
				{
					return;
				}
				_playerIsInSurroundingArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(123)] 
		[RED("proximityExplosionEventID")] 
		public gameDelayID ProximityExplosionEventID
		{
			get
			{
				if (_proximityExplosionEventID == null)
				{
					_proximityExplosionEventID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "proximityExplosionEventID", cr2w, this);
				}
				return _proximityExplosionEventID;
			}
			set
			{
				if (_proximityExplosionEventID == value)
				{
					return;
				}
				_proximityExplosionEventID = value;
				PropertySet(this);
			}
		}

		[Ordinal(124)] 
		[RED("proximityExplosionEventSent")] 
		public CBool ProximityExplosionEventSent
		{
			get
			{
				if (_proximityExplosionEventSent == null)
				{
					_proximityExplosionEventSent = (CBool) CR2WTypeManager.Create("Bool", "proximityExplosionEventSent", cr2w, this);
				}
				return _proximityExplosionEventSent;
			}
			set
			{
				if (_proximityExplosionEventSent == value)
				{
					return;
				}
				_proximityExplosionEventSent = value;
				PropertySet(this);
			}
		}

		public ExplosiveTriggerDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
