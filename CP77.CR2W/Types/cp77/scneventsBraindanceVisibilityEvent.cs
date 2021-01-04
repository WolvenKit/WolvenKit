using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsBraindanceVisibilityEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("customMaterialParam")] public CEnum<ECustomMaterialParam> CustomMaterialParam { get; set; }
		[Ordinal(1)]  [RED("eventStartEndBlend")] public CFloat EventStartEndBlend { get; set; }
		[Ordinal(2)]  [RED("override")] public CBool Override { get; set; }
		[Ordinal(3)]  [RED("parameterIndex")] public CUInt32 ParameterIndex { get; set; }
		[Ordinal(4)]  [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(5)]  [RED("perspectiveBlend")] public CFloat PerspectiveBlend { get; set; }
		[Ordinal(6)]  [RED("priority")] public CUInt8 Priority { get; set; }
		[Ordinal(7)]  [RED("renderSettingsFPP")] public WorldRenderAreaSettings RenderSettingsFPP { get; set; }
		[Ordinal(8)]  [RED("renderSettingsTPP")] public WorldRenderAreaSettings RenderSettingsTPP { get; set; }

		public scneventsBraindanceVisibilityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
