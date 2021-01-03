using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DialerContactDataView : inkScriptableDataViewWrapper
	{
		[Ordinal(0)]  [RED("compareBuilder")] public CHandle<CompareBuilder> CompareBuilder { get; set; }

		public DialerContactDataView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
