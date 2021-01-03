using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAdditionalFloatTrackEntry : ISerializable
	{
		[Ordinal(0)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(1)]  [RED("trackInfo")] public animFloatTrackInfo TrackInfo { get; set; }
		[Ordinal(2)]  [RED("values")] public curveData<CFloat> Values { get; set; }

		public animAdditionalFloatTrackEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
