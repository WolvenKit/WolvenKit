using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameAnimFeature_TPPRepresentation : animAnimFeature
	{
		[Ordinal(0)]  [RED("IsActive")] public CBool IsActive { get; set; }

		public gameAnimFeature_TPPRepresentation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
