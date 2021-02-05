using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EntitiesAtGate : MorphData
	{
		[Ordinal(0)]  [RED("changed")] public CBool Changed { get; set; }
		[Ordinal(1)]  [RED("entitiesAtGate")] public CArray<entEntityID> _EntitiesAtGate { get; set; }

		public EntitiesAtGate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
