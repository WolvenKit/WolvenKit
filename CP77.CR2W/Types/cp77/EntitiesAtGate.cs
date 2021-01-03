using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EntitiesAtGate : MorphData
	{
		[Ordinal(0)]  [RED("entitiesAtGate")] public CArray<entEntityID> M_EntitiesAtGate { get; set; }

		public EntitiesAtGate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
