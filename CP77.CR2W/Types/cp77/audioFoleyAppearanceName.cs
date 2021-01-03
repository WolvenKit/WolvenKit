using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioFoleyAppearanceName : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("void")] public CBool Void { get; set; }

		public audioFoleyAppearanceName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
