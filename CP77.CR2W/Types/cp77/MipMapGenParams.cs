using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MipMapGenParams : CVariable
	{
		[Ordinal(0)]  [RED("applyToksvig_Channel")] public CUInt8 ApplyToksvig_Channel { get; set; }
		[Ordinal(1)]  [RED("applyToksvig_ShouldInvChannel")] public CBool ApplyToksvig_ShouldInvChannel { get; set; }
		[Ordinal(2)]  [RED("applyToksvig_sourceNormalMap")] public raRef<CBitmapTexture> ApplyToksvig_sourceNormalMap { get; set; }

		public MipMapGenParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
