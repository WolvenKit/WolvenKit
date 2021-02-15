using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DelayedVisibilityInAnimSystemRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("data")] public CHandle<ForcedVisibilityInAnimSystemData> Data { get; set; }
		[Ordinal(1)] [RED("isVisible")] public CBool IsVisible { get; set; }
		[Ordinal(2)] [RED("entityID")] public entEntityID EntityID { get; set; }

		public DelayedVisibilityInAnimSystemRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
