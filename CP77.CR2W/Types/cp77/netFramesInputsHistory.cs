using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class netFramesInputsHistory : CVariable
	{
		[Ordinal(0)]  [RED("frames")] public CArray<netFrameInputs> Frames { get; set; }

		public netFramesInputsHistory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
