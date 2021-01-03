using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SendInstructionRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("jobs")] public CArray<HUDJob> Jobs { get; set; }

		public SendInstructionRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
