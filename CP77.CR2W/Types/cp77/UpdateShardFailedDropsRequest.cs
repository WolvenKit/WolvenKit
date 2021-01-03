using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UpdateShardFailedDropsRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("newFailedAttempts")] public CFloat NewFailedAttempts { get; set; }
		[Ordinal(1)]  [RED("resetCounter")] public CBool ResetCounter { get; set; }

		public UpdateShardFailedDropsRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
