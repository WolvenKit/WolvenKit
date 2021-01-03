using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entdismembermentWoundsConfigSet : CVariable
	{
		[Ordinal(0)]  [RED("Configs")] public CArray<CHandle<entdismembermentWoundConfigContainer>> Configs { get; set; }

		public entdismembermentWoundsConfigSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
