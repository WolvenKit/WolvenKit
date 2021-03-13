using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioUiControlMap : audioAudioMetadata
	{
		[Ordinal(1)] [RED("uiControlsByName")] public CHandle<audioKeyUiControlDictionary> UiControlsByName { get; set; }

		public audioUiControlMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
