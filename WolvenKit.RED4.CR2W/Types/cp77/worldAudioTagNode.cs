using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAudioTagNode : worldNode
	{
		[Ordinal(4)] [RED("audioTag")] public CName AudioTag { get; set; }
		[Ordinal(5)] [RED("radius")] public CFloat Radius { get; set; }

		public worldAudioTagNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
