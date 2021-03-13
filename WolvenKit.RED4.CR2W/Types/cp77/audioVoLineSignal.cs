using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoLineSignal : CVariable
	{
		[Ordinal(0)] [RED("ruid")] public CRUID Ruid { get; set; }
		[Ordinal(1)] [RED("signal")] public CName Signal { get; set; }

		public audioVoLineSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
