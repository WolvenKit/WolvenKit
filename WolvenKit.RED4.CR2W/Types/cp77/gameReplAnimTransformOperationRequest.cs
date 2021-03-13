using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplAnimTransformOperationRequest : gameReplAnimTransformRequestBase
	{
		[Ordinal(1)] [RED("animName")] public CName AnimName { get; set; }
		[Ordinal(2)] [RED("operationType")] public CUInt8 OperationType { get; set; }

		public gameReplAnimTransformOperationRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
