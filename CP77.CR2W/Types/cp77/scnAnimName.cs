using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnAnimName : ISerializable
	{
		[Ordinal(0)]  [RED("type")] public CEnum<scnAnimNameType> Type { get; set; }

		public scnAnimName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
