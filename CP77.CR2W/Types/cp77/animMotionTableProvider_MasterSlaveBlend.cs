using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animMotionTableProvider_MasterSlaveBlend : animIMotionTableProvider
	{
		[Ordinal(5)] [RED("masterInputIdx")] public CUInt8 MasterInputIdx { get; set; }

		public animMotionTableProvider_MasterSlaveBlend(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
