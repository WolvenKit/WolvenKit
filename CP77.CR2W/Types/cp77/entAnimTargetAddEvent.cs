using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entAnimTargetAddEvent : redEvent
	{
		[Ordinal(0)]  [RED("bodyPart")] public CName BodyPart { get; set; }
		[Ordinal(1)]  [RED("targetPositionProvider")] public CHandle<entIPositionProvider> TargetPositionProvider { get; set; }

		public entAnimTargetAddEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
