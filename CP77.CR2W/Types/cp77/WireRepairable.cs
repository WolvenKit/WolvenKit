using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class WireRepairable : gameObject
	{
		[Ordinal(0)]  [RED("brokenmesh")] public CHandle<entIVisualComponent> Brokenmesh { get; set; }
		[Ordinal(1)]  [RED("dependableEntities")] public CArray<NodeRef> DependableEntities { get; set; }
		[Ordinal(2)]  [RED("fixedmesh")] public CHandle<entIVisualComponent> Fixedmesh { get; set; }
		[Ordinal(3)]  [RED("interaction")] public CHandle<gameinteractionsComponent> Interaction { get; set; }
		[Ordinal(4)]  [RED("isBroken")] public CBool IsBroken { get; set; }

		public WireRepairable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
