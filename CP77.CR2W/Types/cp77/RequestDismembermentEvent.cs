using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RequestDismembermentEvent : AIAIEvent
	{
		[Ordinal(0)]  [RED("bodyPart")] public CEnum<gameDismBodyPart> BodyPart { get; set; }
		[Ordinal(1)]  [RED("dismembermentType")] public CEnum<gameDismWoundType> DismembermentType { get; set; }
		[Ordinal(2)]  [RED("hitPosition")] public Vector4 HitPosition { get; set; }
		[Ordinal(3)]  [RED("isCritical")] public CBool IsCritical { get; set; }

		public RequestDismembermentEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
