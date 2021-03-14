using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_DodgeData : animAnimFeature
	{
		[Ordinal(0)] [RED("dodgeType")] public CInt32 DodgeType { get; set; }
		[Ordinal(1)] [RED("dodgeDirection")] public CInt32 DodgeDirection { get; set; }

		public animAnimFeature_DodgeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
