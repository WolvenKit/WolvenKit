using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_ChestPress : animAnimFeature
	{
		[Ordinal(0)]  [RED("kill")] public CBool Kill { get; set; }
		[Ordinal(1)]  [RED("lifting")] public CBool Lifting { get; set; }

		public AnimFeature_ChestPress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
