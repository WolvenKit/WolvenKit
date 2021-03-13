using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealNetworkRequestRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("target")] public entEntityID Target { get; set; }
		[Ordinal(1)] [RED("delay")] public CFloat Delay { get; set; }

		public RevealNetworkRequestRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
