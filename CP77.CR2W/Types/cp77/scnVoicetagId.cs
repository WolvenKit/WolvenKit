using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnVoicetagId : CVariable
	{
		[Ordinal(0)]  [RED("id")] public CRUID Id { get; set; }

		public scnVoicetagId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
