using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VentilationArea : InteractiveMasterDevice
	{
		[Ordinal(0)]  [RED("AttackRecord")] public CString AttackRecord { get; set; }
		[Ordinal(1)]  [RED("RestartGameEffectOnAttach")] public CBool RestartGameEffectOnAttach { get; set; }
		[Ordinal(2)]  [RED("areaComponent")] public CHandle<gameStaticTriggerAreaComponent> AreaComponent { get; set; }
		[Ordinal(3)]  [RED("gameEffect")] public CHandle<gameEffectInstance> GameEffect { get; set; }
		[Ordinal(4)]  [RED("gameEffectRef")] public gameEffectRef GameEffectRef { get; set; }
		[Ordinal(5)]  [RED("highLightActive")] public CBool HighLightActive { get; set; }

		public VentilationArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
