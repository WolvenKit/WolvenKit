using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VentilationArea : InteractiveMasterDevice
	{
		[Ordinal(84)]  [RED("areaComponent")] public CHandle<gameStaticTriggerAreaComponent> AreaComponent { get; set; }
		[Ordinal(85)]  [RED("RestartGameEffectOnAttach")] public CBool RestartGameEffectOnAttach { get; set; }
		[Ordinal(86)]  [RED("AttackRecord")] public CString AttackRecord { get; set; }
		[Ordinal(87)]  [RED("gameEffectRef")] public gameEffectRef GameEffectRef { get; set; }
		[Ordinal(88)]  [RED("gameEffect")] public CHandle<gameEffectInstance> GameEffect { get; set; }
		[Ordinal(89)]  [RED("highLightActive")] public CBool HighLightActive { get; set; }

		public VentilationArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
