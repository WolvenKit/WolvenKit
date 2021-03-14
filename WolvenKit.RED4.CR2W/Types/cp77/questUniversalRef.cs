using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questUniversalRef : ISerializable
	{
		[Ordinal(0)] [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
		[Ordinal(1)] [RED("refLocalPlayer")] public CBool RefLocalPlayer { get; set; }
		[Ordinal(2)] [RED("mainPlayerObject")] public CBool MainPlayerObject { get; set; }

		public questUniversalRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
