using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SetIsInBraindance : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("newState")] public CBool NewState { get; set; }

		public SetIsInBraindance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
