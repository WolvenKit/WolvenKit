using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questIONodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(0)]  [RED("socketName")] public CName SocketName { get; set; }

		public questIONodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
