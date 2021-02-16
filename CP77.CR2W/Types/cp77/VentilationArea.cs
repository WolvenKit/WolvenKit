using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VentilationArea : InteractiveMasterDevice
	{
		[Ordinal(93)] [RED("areaComponent")] public CHandle<gameStaticTriggerAreaComponent> AreaComponent { get; set; }
		[Ordinal(94)] [RED("RestartGameEffectOnAttach")] public CBool RestartGameEffectOnAttach { get; set; }
		[Ordinal(95)] [RED("AttackRecord")] public CString AttackRecord { get; set; }
		[Ordinal(96)] [RED("gameEffectRef")] public gameEffectRef GameEffectRef { get; set; }
		[Ordinal(97)] [RED("gameEffect")] public CHandle<gameEffectInstance> GameEffect { get; set; }
		[Ordinal(98)] [RED("highLightActive")] public CBool HighLightActive { get; set; }

		public VentilationArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
