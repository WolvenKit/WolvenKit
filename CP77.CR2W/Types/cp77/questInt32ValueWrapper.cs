using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questInt32ValueWrapper : CVariable
	{
		[Ordinal(0)]  [RED("valueProvider")] public CHandle<questIInt32ValueProvider> ValueProvider { get; set; }

		public questInt32ValueWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
