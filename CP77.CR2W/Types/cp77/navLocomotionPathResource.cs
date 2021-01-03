using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class navLocomotionPathResource : CResource
	{
		[Ordinal(0)]  [RED("paths")] public CArray<CHandle<navLocomotionPath>> Paths { get; set; }

		public navLocomotionPathResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
