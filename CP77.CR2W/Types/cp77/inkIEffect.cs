using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkIEffect : ISerializable
	{
		[Ordinal(0)]  [RED("effectName")] public CName EffectName { get; set; }
		[Ordinal(1)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public inkIEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
