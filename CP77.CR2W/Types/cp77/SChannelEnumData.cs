using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SChannelEnumData : CVariable
	{
		[Ordinal(0)]  [RED("channel")] public CEnum<ETVChannel> Channel { get; set; }

		public SChannelEnumData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
