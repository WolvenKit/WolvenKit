using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WireRepairable : gameObject
	{
		private CBool _isBroken;
		private CArray<NodeRef> _dependableEntities;
		private CHandle<gameinteractionsComponent> _interaction;
		private CHandle<entIVisualComponent> _brokenmesh;
		private CHandle<entIVisualComponent> _fixedmesh;

		[Ordinal(40)] 
		[RED("isBroken")] 
		public CBool IsBroken
		{
			get => GetProperty(ref _isBroken);
			set => SetProperty(ref _isBroken, value);
		}

		[Ordinal(41)] 
		[RED("dependableEntities")] 
		public CArray<NodeRef> DependableEntities
		{
			get => GetProperty(ref _dependableEntities);
			set => SetProperty(ref _dependableEntities, value);
		}

		[Ordinal(42)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetProperty(ref _interaction);
			set => SetProperty(ref _interaction, value);
		}

		[Ordinal(43)] 
		[RED("brokenmesh")] 
		public CHandle<entIVisualComponent> Brokenmesh
		{
			get => GetProperty(ref _brokenmesh);
			set => SetProperty(ref _brokenmesh, value);
		}

		[Ordinal(44)] 
		[RED("fixedmesh")] 
		public CHandle<entIVisualComponent> Fixedmesh
		{
			get => GetProperty(ref _fixedmesh);
			set => SetProperty(ref _fixedmesh, value);
		}

		public WireRepairable(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
