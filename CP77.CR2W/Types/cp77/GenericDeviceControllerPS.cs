using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GenericDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("isRecognizableBySenses")] public CBool IsRecognizableBySenses { get; set; }
		[Ordinal(104)] [RED("genericDeviceActionsSetup")] public GenericDeviceActionsData GenericDeviceActionsSetup { get; set; }
		[Ordinal(105)] [RED("genericDeviceSkillChecks")] public CHandle<GenericContainer> GenericDeviceSkillChecks { get; set; }
		[Ordinal(106)] [RED("deviceWidgetRecord")] public TweakDBID DeviceWidgetRecord { get; set; }
		[Ordinal(107)] [RED("thumbnailWidgetRecord")] public TweakDBID ThumbnailWidgetRecord { get; set; }
		[Ordinal(108)] [RED("performedCustomActionsIDs")] public CArray<CName> PerformedCustomActionsIDs { get; set; }

		public GenericDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
