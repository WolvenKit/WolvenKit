using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TaggedObjectsListDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("taggedObjectsList")] public gamebbScriptID_Variant TaggedObjectsList { get; set; }

		public TaggedObjectsListDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
