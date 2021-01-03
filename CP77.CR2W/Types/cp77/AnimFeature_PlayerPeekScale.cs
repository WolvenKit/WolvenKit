using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PlayerPeekScale : animAnimFeature
	{
		[Ordinal(0)]  [RED("peekScale")] public CFloat PeekScale { get; set; }

		public AnimFeature_PlayerPeekScale(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
