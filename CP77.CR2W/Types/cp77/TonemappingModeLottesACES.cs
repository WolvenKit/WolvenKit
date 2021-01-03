using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TonemappingModeLottesACES : ITonemappingMode
	{
		[Ordinal(0)]  [RED("contrast")] public CFloat Contrast { get; set; }
		[Ordinal(1)]  [RED("maxInput")] public CFloat MaxInput { get; set; }
		[Ordinal(2)]  [RED("midIn")] public CFloat MidIn { get; set; }
		[Ordinal(3)]  [RED("midOut")] public CFloat MidOut { get; set; }

		public TonemappingModeLottesACES(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
