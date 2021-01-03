using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class sampleVisClueMaster : gameObject
	{
		[Ordinal(0)]  [RED("dependableEntities")] public CArray<NodeRef> DependableEntities { get; set; }

		public sampleVisClueMaster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
