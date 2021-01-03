using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vehiclePortalsList : IScriptable
	{
		[Ordinal(0)]  [RED("listPoints")] public CArray<NodeRef> ListPoints { get; set; }

		public vehiclePortalsList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
