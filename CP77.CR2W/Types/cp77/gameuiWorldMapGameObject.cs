using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapGameObject : gameObject
	{
		[Ordinal(0)]  [RED("districts")] public CArray<gameuiDistrictTriggerData> Districts { get; set; }

		public gameuiWorldMapGameObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
