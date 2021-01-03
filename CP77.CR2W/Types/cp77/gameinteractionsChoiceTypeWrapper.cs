using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceTypeWrapper : CVariable
	{
		[Ordinal(0)]  [RED("properties")] public CUInt32 Properties { get; set; }

		public gameinteractionsChoiceTypeWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
