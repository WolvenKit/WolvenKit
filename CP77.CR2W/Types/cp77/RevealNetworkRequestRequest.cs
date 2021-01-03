using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RevealNetworkRequestRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("delay")] public CFloat Delay { get; set; }
		[Ordinal(1)]  [RED("target")] public entEntityID Target { get; set; }

		public RevealNetworkRequestRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
