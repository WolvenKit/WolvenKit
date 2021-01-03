using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceNPC : ActivatedDeviceTransfromAnim
	{
		[Ordinal(0)]  [RED("hasProperAnimations")] public CBool HasProperAnimations { get; set; }

		public ActivatedDeviceNPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
