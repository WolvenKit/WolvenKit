using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnChatterModuleSharedState : ISerializable
	{
		[Ordinal(0)]  [RED("chatterHistory")] public CArray<CHandle<scnChatter>> ChatterHistory { get; set; }

		public scnChatterModuleSharedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
