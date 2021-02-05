using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioEditorSelectedData : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("selectedWeaponConfigurationName")] public CName SelectedWeaponConfigurationName { get; set; }
		[Ordinal(1)]  [RED("selectedFootstepsEventName")] public CName SelectedFootstepsEventName { get; set; }

		public audioEditorSelectedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
