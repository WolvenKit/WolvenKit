using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animCAnimationBufferUncompressed : animIAnimationBuffer
	{
		[Ordinal(0)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)]  [RED("tracks")] public CArray<CArray<CFloat>> Tracks { get; set; }
		[Ordinal(2)]  [RED("transforms")] public CArray<CArray<QsTransform>> Transforms { get; set; }

		public animCAnimationBufferUncompressed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
