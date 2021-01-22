using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioUiControlMap : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("uiControlsByName")] public CHandle<audioKeyUiControlDictionary> UiControlsByName { get; set; }

		public audioUiControlMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
