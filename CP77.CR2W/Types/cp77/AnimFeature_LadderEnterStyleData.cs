using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_LadderEnterStyleData : animAnimFeature
	{
		[Ordinal(0)]  [RED("enterStyle")] public CInt32 EnterStyle { get; set; }

		public AnimFeature_LadderEnterStyleData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
