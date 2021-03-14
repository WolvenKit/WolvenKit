using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNodeSourceChannel_StaticQsTransform : animIAnimNodeSourceChannel_QsTransform
	{
		[Ordinal(0)] [RED("data")] public QsTransform Data { get; set; }

		public animAnimNodeSourceChannel_StaticQsTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
