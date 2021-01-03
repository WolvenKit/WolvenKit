using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DocumentCustomData : IScriptable
	{
		[Ordinal(0)]  [RED("id")] public CInt32 Id { get; set; }
		[Ordinal(1)]  [RED("type")] public CEnum<EDocumentType> Type { get; set; }

		public DocumentCustomData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
