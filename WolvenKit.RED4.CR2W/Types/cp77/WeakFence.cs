using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeakFence : InteractiveDevice
	{
		private CFloat _impulseForce;
		private Vector4 _impulseVector;
		private CArray<CName> _sideTriggerNames;
		private CArray<CHandle<gameStaticTriggerAreaComponent>> _triggerComponents;
		private CName _currentWorkspotSuffix;
		private CHandle<AIOffMeshConnectionComponent> _offMeshConnectionComponent;
		private CHandle<entIPlacedComponent> _physicalMesh;

		[Ordinal(93)] 
		[RED("impulseForce")] 
		public CFloat ImpulseForce
		{
			get
			{
				if (_impulseForce == null)
				{
					_impulseForce = (CFloat) CR2WTypeManager.Create("Float", "impulseForce", cr2w, this);
				}
				return _impulseForce;
			}
			set
			{
				if (_impulseForce == value)
				{
					return;
				}
				_impulseForce = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("impulseVector")] 
		public Vector4 ImpulseVector
		{
			get
			{
				if (_impulseVector == null)
				{
					_impulseVector = (Vector4) CR2WTypeManager.Create("Vector4", "impulseVector", cr2w, this);
				}
				return _impulseVector;
			}
			set
			{
				if (_impulseVector == value)
				{
					return;
				}
				_impulseVector = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("sideTriggerNames")] 
		public CArray<CName> SideTriggerNames
		{
			get
			{
				if (_sideTriggerNames == null)
				{
					_sideTriggerNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "sideTriggerNames", cr2w, this);
				}
				return _sideTriggerNames;
			}
			set
			{
				if (_sideTriggerNames == value)
				{
					return;
				}
				_sideTriggerNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("triggerComponents")] 
		public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents
		{
			get
			{
				if (_triggerComponents == null)
				{
					_triggerComponents = (CArray<CHandle<gameStaticTriggerAreaComponent>>) CR2WTypeManager.Create("array:handle:gameStaticTriggerAreaComponent", "triggerComponents", cr2w, this);
				}
				return _triggerComponents;
			}
			set
			{
				if (_triggerComponents == value)
				{
					return;
				}
				_triggerComponents = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("currentWorkspotSuffix")] 
		public CName CurrentWorkspotSuffix
		{
			get
			{
				if (_currentWorkspotSuffix == null)
				{
					_currentWorkspotSuffix = (CName) CR2WTypeManager.Create("CName", "currentWorkspotSuffix", cr2w, this);
				}
				return _currentWorkspotSuffix;
			}
			set
			{
				if (_currentWorkspotSuffix == value)
				{
					return;
				}
				_currentWorkspotSuffix = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
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

		[Ordinal(99)] 
		[RED("physicalMesh")] 
		public CHandle<entIPlacedComponent> PhysicalMesh
		{
			get
			{
				if (_physicalMesh == null)
				{
					_physicalMesh = (CHandle<entIPlacedComponent>) CR2WTypeManager.Create("handle:entIPlacedComponent", "physicalMesh", cr2w, this);
				}
				return _physicalMesh;
			}
			set
			{
				if (_physicalMesh == value)
				{
					return;
				}
				_physicalMesh = value;
				PropertySet(this);
			}
		}

		public WeakFence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
