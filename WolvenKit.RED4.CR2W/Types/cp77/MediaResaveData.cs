using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MediaResaveData : CVariable
	{
		[Ordinal(0)] [RED("mediaDeviceData")] public MediaDeviceData MediaDeviceData { get; set; }

		public MediaResaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
