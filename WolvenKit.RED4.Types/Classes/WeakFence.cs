using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeakFence : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("impulseForce")] 
		public CFloat ImpulseForce
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(98)] 
		[RED("impulseVector")] 
		public Vector4 ImpulseVector
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(99)] 
		[RED("sideTriggerNames")] 
		public CArray<CName> SideTriggerNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(100)] 
		[RED("triggerComponents")] 
		public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents
		{
			get => GetPropertyValue<CArray<CHandle<gameStaticTriggerAreaComponent>>>();
			set => SetPropertyValue<CArray<CHandle<gameStaticTriggerAreaComponent>>>(value);
		}

		[Ordinal(101)] 
		[RED("currentWorkspotSuffix")] 
		public CName CurrentWorkspotSuffix
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(102)] 
		[RED("offMeshConnectionComponent")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent
		{
			get => GetPropertyValue<CHandle<AIOffMeshConnectionComponent>>();
			set => SetPropertyValue<CHandle<AIOffMeshConnectionComponent>>(value);
		}

		[Ordinal(103)] 
		[RED("physicalMesh")] 
		public CHandle<entIPlacedComponent> PhysicalMesh
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		public WeakFence()
		{
			ImpulseVector = new();
			SideTriggerNames = new();
			TriggerComponents = new();
		}
	}
}
