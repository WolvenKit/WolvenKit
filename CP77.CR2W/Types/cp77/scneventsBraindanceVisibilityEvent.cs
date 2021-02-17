using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsBraindanceVisibilityEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(7)] [RED("customMaterialParam")] public CEnum<ECustomMaterialParam> CustomMaterialParam { get; set; }
		[Ordinal(8)] [RED("parameterIndex")] public CUInt32 ParameterIndex { get; set; }
		[Ordinal(9)] [RED("override")] public CBool Override { get; set; }
		[Ordinal(10)] [RED("priority")] public CUInt8 Priority { get; set; }
		[Ordinal(11)] [RED("eventStartEndBlend")] public CFloat EventStartEndBlend { get; set; }
		[Ordinal(12)] [RED("perspectiveBlend")] public CFloat PerspectiveBlend { get; set; }
		[Ordinal(13)] [RED("renderSettingsFPP")] public WorldRenderAreaSettings RenderSettingsFPP { get; set; }
		[Ordinal(14)] [RED("renderSettingsTPP")] public WorldRenderAreaSettings RenderSettingsTPP { get; set; }

		public scneventsBraindanceVisibilityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
