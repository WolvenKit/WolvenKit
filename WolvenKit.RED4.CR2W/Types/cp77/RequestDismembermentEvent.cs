using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestDismembermentEvent : AIAIEvent
	{
		[Ordinal(2)] [RED("bodyPart")] public CEnum<gameDismBodyPart> BodyPart { get; set; }
		[Ordinal(3)] [RED("dismembermentType")] public CEnum<gameDismWoundType> DismembermentType { get; set; }
		[Ordinal(4)] [RED("hitPosition")] public Vector4 HitPosition { get; set; }
		[Ordinal(5)] [RED("isCritical")] public CBool IsCritical { get; set; }

		public RequestDismembermentEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
