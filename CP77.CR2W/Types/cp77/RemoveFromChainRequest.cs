using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RemoveFromChainRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("requestSource")] public entEntityID RequestSource { get; set; }

		public RemoveFromChainRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
