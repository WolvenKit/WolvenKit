using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WireRepairable : gameObject
	{
		[Ordinal(40)] [RED("isBroken")] public CBool IsBroken { get; set; }
		[Ordinal(41)] [RED("dependableEntities")] public CArray<NodeRef> DependableEntities { get; set; }
		[Ordinal(42)] [RED("interaction")] public CHandle<gameinteractionsComponent> Interaction { get; set; }
		[Ordinal(43)] [RED("brokenmesh")] public CHandle<entIVisualComponent> Brokenmesh { get; set; }
		[Ordinal(44)] [RED("fixedmesh")] public CHandle<entIVisualComponent> Fixedmesh { get; set; }

		public WireRepairable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
