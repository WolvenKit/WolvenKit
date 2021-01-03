using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ForcedVisibilityInAnimSystemData : IScriptable
	{
		[Ordinal(0)]  [RED("delayID")] public gameDelayID DelayID { get; set; }
		[Ordinal(1)]  [RED("forcedVisibleOnlyInFrustum")] public CBool ForcedVisibleOnlyInFrustum { get; set; }
		[Ordinal(2)]  [RED("sourceName")] public CName SourceName { get; set; }

		public ForcedVisibilityInAnimSystemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
