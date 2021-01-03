using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNodeSourceChannel_StaticVector : animIAnimNodeSourceChannel_Vector
	{
		[Ordinal(0)]  [RED("data")] public Vector4 Data { get; set; }

		public animAnimNodeSourceChannel_StaticVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
