using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UnlockCodexPartRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("codexRecordID")] public TweakDBID CodexRecordID { get; set; }
		[Ordinal(1)]  [RED("partName")] public CName PartName { get; set; }

		public UnlockCodexPartRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
