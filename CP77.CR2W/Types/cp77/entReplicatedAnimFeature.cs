using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entReplicatedAnimFeature : entReplicatedItem
	{
		[Ordinal(0)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(1)]  [RED("value")] public CHandle<animAnimFeature> Value { get; set; }
		[Ordinal(2)]  [RED("invokeCallback")] public CBool InvokeCallback { get; set; }

		public entReplicatedAnimFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
