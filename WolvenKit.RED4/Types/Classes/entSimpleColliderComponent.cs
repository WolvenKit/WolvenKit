using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entSimpleColliderComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("colliders")] 
		public CArray<CHandle<physicsICollider>> Colliders
		{
			get => GetPropertyValue<CArray<CHandle<physicsICollider>>>();
			set => SetPropertyValue<CArray<CHandle<physicsICollider>>>(value);
		}

		[Ordinal(7)] 
		[RED("filter")] 
		public CHandle<physicsFilterData> Filter
		{
			get => GetPropertyValue<CHandle<physicsFilterData>>();
			set => SetPropertyValue<CHandle<physicsFilterData>>(value);
		}

		[Ordinal(8)] 
		[RED("compiledBuffer")] 
		public DataBuffer CompiledBuffer
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		public entSimpleColliderComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			IsEnabled = true;
			Colliders = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
