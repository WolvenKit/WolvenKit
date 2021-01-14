using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EnableFastTravelRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("forceRefreshUI")] public CBool ForceRefreshUI { get; set; }
		[Ordinal(1)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(2)]  [RED("linkedStatusEffectID")] public TweakDBID LinkedStatusEffectID { get; set; }
		[Ordinal(3)]  [RED("reason")] public CName Reason { get; set; }

		public EnableFastTravelRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
