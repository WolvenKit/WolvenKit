using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GenericDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("deviceWidgetRecord")] public TweakDBID DeviceWidgetRecord { get; set; }
		[Ordinal(1)]  [RED("genericDeviceActionsSetup")] public GenericDeviceActionsData GenericDeviceActionsSetup { get; set; }
		[Ordinal(2)]  [RED("genericDeviceSkillChecks")] public CHandle<GenericContainer> GenericDeviceSkillChecks { get; set; }
		[Ordinal(3)]  [RED("isRecognizableBySenses")] public CBool IsRecognizableBySenses { get; set; }
		[Ordinal(4)]  [RED("performedCustomActionsIDs")] public CArray<CName> PerformedCustomActionsIDs { get; set; }
		[Ordinal(5)]  [RED("thumbnailWidgetRecord")] public TweakDBID ThumbnailWidgetRecord { get; set; }

		public GenericDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
