using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WireRepairable : gameObject
	{
		[Ordinal(40)] 
		[RED("isBroken")] 
		public CBool IsBroken
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(41)] 
		[RED("dependableEntities")] 
		public CArray<NodeRef> DependableEntities
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		[Ordinal(42)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetPropertyValue<CHandle<gameinteractionsComponent>>();
			set => SetPropertyValue<CHandle<gameinteractionsComponent>>(value);
		}

		[Ordinal(43)] 
		[RED("brokenmesh")] 
		public CHandle<entIVisualComponent> Brokenmesh
		{
			get => GetPropertyValue<CHandle<entIVisualComponent>>();
			set => SetPropertyValue<CHandle<entIVisualComponent>>(value);
		}

		[Ordinal(44)] 
		[RED("fixedmesh")] 
		public CHandle<entIVisualComponent> Fixedmesh
		{
			get => GetPropertyValue<CHandle<entIVisualComponent>>();
			set => SetPropertyValue<CHandle<entIVisualComponent>>(value);
		}

		public WireRepairable()
		{
			DependableEntities = new();
		}
	}
}
