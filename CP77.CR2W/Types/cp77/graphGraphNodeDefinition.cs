using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class graphGraphNodeDefinition : graphIGraphObjectDefinition
	{
		[Ordinal(0)]  [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }

		public graphGraphNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
