using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecuritySystemMorphData : RedBaseClass
	{
		private CHandle<State> _state;
		private CHandle<Reprimand> _reprimandData;
		private CHandle<Blacklist> _blacklist;
		private CHandle<ProtectedEntities> _protectedEntities;
		private CHandle<EntitiesAtGate> _entitiesAtGate;

		[Ordinal(0)] 
		[RED("state")] 
		public CHandle<State> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("reprimandData")] 
		public CHandle<Reprimand> ReprimandData
		{
			get => GetProperty(ref _reprimandData);
			set => SetProperty(ref _reprimandData, value);
		}

		[Ordinal(2)] 
		[RED("blacklist")] 
		public CHandle<Blacklist> Blacklist
		{
			get => GetProperty(ref _blacklist);
			set => SetProperty(ref _blacklist, value);
		}

		[Ordinal(3)] 
		[RED("protectedEntities")] 
		public CHandle<ProtectedEntities> ProtectedEntities
		{
			get => GetProperty(ref _protectedEntities);
			set => SetProperty(ref _protectedEntities, value);
		}

		[Ordinal(4)] 
		[RED("entitiesAtGate")] 
		public CHandle<EntitiesAtGate> EntitiesAtGate
		{
			get => GetProperty(ref _entitiesAtGate);
			set => SetProperty(ref _entitiesAtGate, value);
		}
	}
}
