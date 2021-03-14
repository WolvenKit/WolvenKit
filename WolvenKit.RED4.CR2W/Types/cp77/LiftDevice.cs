using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LiftDevice : InteractiveMasterDevice
	{
		private CArray<CName> _advertismentNames;
		private CArray<CHandle<entIPlacedComponent>> _advertisments;
		private CHandle<gameMovingPlatform> _movingPlatform;
		private CArray<ElevatorFloorSetup> _floors;
		private CArray<CHandle<entIPlacedComponent>> _questSafeguardColliders;
		private CArray<CName> _questSafeguardColliderNames;
		private CHandle<entIPlacedComponent> _frontDoorOccluder;
		private CHandle<entIPlacedComponent> _backDoorOccluder;
		private CHandle<entIPlacedComponent> _radioMesh;
		private CHandle<entIPlacedComponent> _radioDestroyed;
		private CHandle<AIOffMeshConnectionComponent> _offMeshConnectionComponent;
		private CBool _isLoadPerformed;

		[Ordinal(93)] 
		[RED("advertismentNames")] 
		public CArray<CName> AdvertismentNames
		{
			get
			{
				if (_advertismentNames == null)
				{
					_advertismentNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "advertismentNames", cr2w, this);
				}
				return _advertismentNames;
			}
			set
			{
				if (_advertismentNames == value)
				{
					return;
				}
				_advertismentNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("advertisments")] 
		public CArray<CHandle<entIPlacedComponent>> Advertisments
		{
			get
			{
				if (_advertisments == null)
				{
					_advertisments = (CArray<CHandle<entIPlacedComponent>>) CR2WTypeManager.Create("array:handle:entIPlacedComponent", "advertisments", cr2w, this);
				}
				return _advertisments;
			}
			set
			{
				if (_advertisments == value)
				{
					return;
				}
				_advertisments = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("movingPlatform")] 
		public CHandle<gameMovingPlatform> MovingPlatform
		{
			get
			{
				if (_movingPlatform == null)
				{
					_movingPlatform = (CHandle<gameMovingPlatform>) CR2WTypeManager.Create("handle:gameMovingPlatform", "movingPlatform", cr2w, this);
				}
				return _movingPlatform;
			}
			set
			{
				if (_movingPlatform == value)
				{
					return;
				}
				_movingPlatform = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("floors")] 
		public CArray<ElevatorFloorSetup> Floors
		{
			get
			{
				if (_floors == null)
				{
					_floors = (CArray<ElevatorFloorSetup>) CR2WTypeManager.Create("array:ElevatorFloorSetup", "floors", cr2w, this);
				}
				return _floors;
			}
			set
			{
				if (_floors == value)
				{
					return;
				}
				_floors = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("QuestSafeguardColliders")] 
		public CArray<CHandle<entIPlacedComponent>> QuestSafeguardColliders
		{
			get
			{
				if (_questSafeguardColliders == null)
				{
					_questSafeguardColliders = (CArray<CHandle<entIPlacedComponent>>) CR2WTypeManager.Create("array:handle:entIPlacedComponent", "QuestSafeguardColliders", cr2w, this);
				}
				return _questSafeguardColliders;
			}
			set
			{
				if (_questSafeguardColliders == value)
				{
					return;
				}
				_questSafeguardColliders = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("QuestSafeguardColliderNames")] 
		public CArray<CName> QuestSafeguardColliderNames
		{
			get
			{
				if (_questSafeguardColliderNames == null)
				{
					_questSafeguardColliderNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "QuestSafeguardColliderNames", cr2w, this);
				}
				return _questSafeguardColliderNames;
			}
			set
			{
				if (_questSafeguardColliderNames == value)
				{
					return;
				}
				_questSafeguardColliderNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(99)] 
		[RED("frontDoorOccluder")] 
		public CHandle<entIPlacedComponent> FrontDoorOccluder
		{
			get
			{
				if (_frontDoorOccluder == null)
				{
					_frontDoorOccluder = (CHandle<entIPlacedComponent>) CR2WTypeManager.Create("handle:entIPlacedComponent", "frontDoorOccluder", cr2w, this);
				}
				return _frontDoorOccluder;
			}
			set
			{
				if (_frontDoorOccluder == value)
				{
					return;
				}
				_frontDoorOccluder = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
		[RED("backDoorOccluder")] 
		public CHandle<entIPlacedComponent> BackDoorOccluder
		{
			get
			{
				if (_backDoorOccluder == null)
				{
					_backDoorOccluder = (CHandle<entIPlacedComponent>) CR2WTypeManager.Create("handle:entIPlacedComponent", "backDoorOccluder", cr2w, this);
				}
				return _backDoorOccluder;
			}
			set
			{
				if (_backDoorOccluder == value)
				{
					return;
				}
				_backDoorOccluder = value;
				PropertySet(this);
			}
		}

		[Ordinal(101)] 
		[RED("radioMesh")] 
		public CHandle<entIPlacedComponent> RadioMesh
		{
			get
			{
				if (_radioMesh == null)
				{
					_radioMesh = (CHandle<entIPlacedComponent>) CR2WTypeManager.Create("handle:entIPlacedComponent", "radioMesh", cr2w, this);
				}
				return _radioMesh;
			}
			set
			{
				if (_radioMesh == value)
				{
					return;
				}
				_radioMesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(102)] 
		[RED("radioDestroyed")] 
		public CHandle<entIPlacedComponent> RadioDestroyed
		{
			get
			{
				if (_radioDestroyed == null)
				{
					_radioDestroyed = (CHandle<entIPlacedComponent>) CR2WTypeManager.Create("handle:entIPlacedComponent", "radioDestroyed", cr2w, this);
				}
				return _radioDestroyed;
			}
			set
			{
				if (_radioDestroyed == value)
				{
					return;
				}
				_radioDestroyed = value;
				PropertySet(this);
			}
		}

		[Ordinal(103)] 
		[RED("offMeshConnectionComponent")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent
		{
			get
			{
				if (_offMeshConnectionComponent == null)
				{
					_offMeshConnectionComponent = (CHandle<AIOffMeshConnectionComponent>) CR2WTypeManager.Create("handle:AIOffMeshConnectionComponent", "offMeshConnectionComponent", cr2w, this);
				}
				return _offMeshConnectionComponent;
			}
			set
			{
				if (_offMeshConnectionComponent == value)
				{
					return;
				}
				_offMeshConnectionComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("isLoadPerformed")] 
		public CBool IsLoadPerformed
		{
			get
			{
				if (_isLoadPerformed == null)
				{
					_isLoadPerformed = (CBool) CR2WTypeManager.Create("Bool", "isLoadPerformed", cr2w, this);
				}
				return _isLoadPerformed;
			}
			set
			{
				if (_isLoadPerformed == value)
				{
					return;
				}
				_isLoadPerformed = value;
				PropertySet(this);
			}
		}

		public LiftDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
