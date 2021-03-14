using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSpawnManagerNodeActionEntry : CVariable
	{
		[Ordinal(0)] [RED("type")] public CHandle<questSpawnManagerNodeType> Type { get; set; }

		public questSpawnManagerNodeActionEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
