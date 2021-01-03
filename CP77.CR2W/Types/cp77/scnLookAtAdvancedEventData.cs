using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnLookAtAdvancedEventData : CVariable
	{
		[Ordinal(0)]  [RED("basic")] public scnAnimTargetBasicData Basic { get; set; }
		[Ordinal(1)]  [RED("requests")] public CArray<animLookAtRequestForPart> Requests { get; set; }

		public scnLookAtAdvancedEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
