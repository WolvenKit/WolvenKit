using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameRandomStatModifierData : gameStatModifierData
	{
		[Ordinal(0)]  [RED("value")] public CFloat Value { get; set; }

		public gameRandomStatModifierData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
