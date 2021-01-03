using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLaneCrowdCreationInfo : CVariable
	{
		[Ordinal(0)]  [RED("connectedFragments")] public CArray<worldTrafficLaneCrowdFragment> ConnectedFragments { get; set; }

		public worldTrafficLaneCrowdCreationInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
