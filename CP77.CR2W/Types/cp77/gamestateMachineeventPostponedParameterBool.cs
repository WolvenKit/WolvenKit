using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineeventPostponedParameterBool : gamestateMachineeventPostponedParameterBase
	{
		[Ordinal(0)]  [RED("value")] public CBool Value { get; set; }

		public gamestateMachineeventPostponedParameterBool(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
