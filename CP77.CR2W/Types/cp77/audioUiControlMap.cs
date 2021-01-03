using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioUiControlMap : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("uiControlsByName")] public CHandle<audioKeyUiControlDictionary> UiControlsByName { get; set; }

		public audioUiControlMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
