using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DismembermentEvent : redEvent
	{
		[Ordinal(0)] [RED("bodyPart")] public CEnum<gameDismBodyPart> BodyPart { get; set; }
		[Ordinal(1)] [RED("woundType")] public CEnum<gameDismWoundType> WoundType { get; set; }
		[Ordinal(2)] [RED("strength")] public CFloat Strength { get; set; }
		[Ordinal(3)] [RED("isCritical")] public CBool IsCritical { get; set; }
		[Ordinal(4)] [RED("debrisPath")] public CString DebrisPath { get; set; }
		[Ordinal(5)] [RED("debrisStrength")] public CFloat DebrisStrength { get; set; }

		public DismembermentEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
