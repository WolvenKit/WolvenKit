using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetBraindanceState : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("newState")] public CBool NewState { get; set; }

		public SetBraindanceState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
