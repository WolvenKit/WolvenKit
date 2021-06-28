using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemMorphData : CVariable
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

		public SecuritySystemMorphData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
