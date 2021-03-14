using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioEditorSelectedData : audioAudioMetadata
	{
		[Ordinal(1)] [RED("selectedWeaponConfigurationName")] public CName SelectedWeaponConfigurationName { get; set; }
		[Ordinal(2)] [RED("selectedFootstepsEventName")] public CName SelectedFootstepsEventName { get; set; }

		public audioEditorSelectedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
