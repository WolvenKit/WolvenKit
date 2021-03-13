using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SendInstructionRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("jobs")] public CArray<HUDJob> Jobs { get; set; }

		public SendInstructionRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
