using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WireRepairable : gameObject
	{
		[Ordinal(35)] 
		[RED("isBroken")] 
		public CBool IsBroken
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("dependableEntities")] 
		public CArray<NodeRef> DependableEntities
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		[Ordinal(37)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetPropertyValue<CHandle<gameinteractionsComponent>>();
			set => SetPropertyValue<CHandle<gameinteractionsComponent>>(value);
		}

		[Ordinal(38)] 
		[RED("brokenmesh")] 
		public CHandle<entIVisualComponent> Brokenmesh
		{
			get => GetPropertyValue<CHandle<entIVisualComponent>>();
			set => SetPropertyValue<CHandle<entIVisualComponent>>(value);
		}

		[Ordinal(39)] 
		[RED("fixedmesh")] 
		public CHandle<entIVisualComponent> Fixedmesh
		{
			get => GetPropertyValue<CHandle<entIVisualComponent>>();
			set => SetPropertyValue<CHandle<entIVisualComponent>>(value);
		}

		public WireRepairable()
		{
			DependableEntities = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
