using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScannerTargetChangedRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("scannerTarget")] public entEntityID ScannerTarget { get; set; }

		public ScannerTargetChangedRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
