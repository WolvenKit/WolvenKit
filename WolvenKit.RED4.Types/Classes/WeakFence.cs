using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeakFence : InteractiveDevice
	{
		private CFloat _impulseForce;
		private Vector4 _impulseVector;
		private CArray<CName> _sideTriggerNames;
		private CArray<CHandle<gameStaticTriggerAreaComponent>> _triggerComponents;
		private CName _currentWorkspotSuffix;
		private CHandle<AIOffMeshConnectionComponent> _offMeshConnectionComponent;
		private CHandle<entIPlacedComponent> _physicalMesh;

		[Ordinal(97)] 
		[RED("impulseForce")] 
		public CFloat ImpulseForce
		{
			get => GetProperty(ref _impulseForce);
			set => SetProperty(ref _impulseForce, value);
		}

		[Ordinal(98)] 
		[RED("impulseVector")] 
		public Vector4 ImpulseVector
		{
			get => GetProperty(ref _impulseVector);
			set => SetProperty(ref _impulseVector, value);
		}

		[Ordinal(99)] 
		[RED("sideTriggerNames")] 
		public CArray<CName> SideTriggerNames
		{
			get => GetProperty(ref _sideTriggerNames);
			set => SetProperty(ref _sideTriggerNames, value);
		}

		[Ordinal(100)] 
		[RED("triggerComponents")] 
		public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents
		{
			get => GetProperty(ref _triggerComponents);
			set => SetProperty(ref _triggerComponents, value);
		}

		[Ordinal(101)] 
		[RED("currentWorkspotSuffix")] 
		public CName CurrentWorkspotSuffix
		{
			get => GetProperty(ref _currentWorkspotSuffix);
			set => SetProperty(ref _currentWorkspotSuffix, value);
		}

		[Ordinal(102)] 
		[RED("offMeshConnectionComponent")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent
		{
			get => GetProperty(ref _offMeshConnectionComponent);
			set => SetProperty(ref _offMeshConnectionComponent, value);
		}

		[Ordinal(103)] 
		[RED("physicalMesh")] 
		public CHandle<entIPlacedComponent> PhysicalMesh
		{
			get => GetProperty(ref _physicalMesh);
			set => SetProperty(ref _physicalMesh, value);
		}
	}
}
