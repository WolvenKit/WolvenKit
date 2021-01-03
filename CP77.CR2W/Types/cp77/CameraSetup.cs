using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CameraSetup : CVariable
	{
		[Ordinal(0)]  [RED("canStreamVideo")] public CBool CanStreamVideo { get; set; }

		public CameraSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
