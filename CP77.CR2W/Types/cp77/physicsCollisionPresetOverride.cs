using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsCollisionPresetOverride : CVariable
	{
		[Ordinal(0)]  [RED("from")] public CName From { get; set; }
		[Ordinal(1)]  [RED("to")] public CName To { get; set; }

		public physicsCollisionPresetOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
