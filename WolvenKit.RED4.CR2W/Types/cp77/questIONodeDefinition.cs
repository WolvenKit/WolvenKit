using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questIONodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] [RED("socketName")] public CName SocketName { get; set; }

		public questIONodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
