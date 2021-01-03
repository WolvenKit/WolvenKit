using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questSpawnManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(0)]  [RED("actions")] public CArray<questSpawnManagerNodeActionEntry> Actions { get; set; }

		public questSpawnManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
