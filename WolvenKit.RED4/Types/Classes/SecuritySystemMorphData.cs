using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecuritySystemMorphData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CHandle<State> State
		{
			get => GetPropertyValue<CHandle<State>>();
			set => SetPropertyValue<CHandle<State>>(value);
		}

		[Ordinal(1)] 
		[RED("reprimandData")] 
		public CHandle<Reprimand> ReprimandData
		{
			get => GetPropertyValue<CHandle<Reprimand>>();
			set => SetPropertyValue<CHandle<Reprimand>>(value);
		}

		[Ordinal(2)] 
		[RED("blacklist")] 
		public CHandle<Blacklist> Blacklist
		{
			get => GetPropertyValue<CHandle<Blacklist>>();
			set => SetPropertyValue<CHandle<Blacklist>>(value);
		}

		[Ordinal(3)] 
		[RED("protectedEntities")] 
		public CHandle<ProtectedEntities> ProtectedEntities
		{
			get => GetPropertyValue<CHandle<ProtectedEntities>>();
			set => SetPropertyValue<CHandle<ProtectedEntities>>(value);
		}

		[Ordinal(4)] 
		[RED("entitiesAtGate")] 
		public CHandle<EntitiesAtGate> EntitiesAtGate
		{
			get => GetPropertyValue<CHandle<EntitiesAtGate>>();
			set => SetPropertyValue<CHandle<EntitiesAtGate>>(value);
		}

		public SecuritySystemMorphData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
