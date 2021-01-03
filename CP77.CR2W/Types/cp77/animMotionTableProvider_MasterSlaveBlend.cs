using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animMotionTableProvider_MasterSlaveBlend : animIMotionTableProvider
	{
		[Ordinal(0)]  [RED("masterInputIdx")] public CUInt8 MasterInputIdx { get; set; }

		public animMotionTableProvider_MasterSlaveBlend(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
