using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LocomotionSceneInitData : IScriptable
	{
		[Ordinal(0)] [RED("previousLocomotionState")] public CInt32 PreviousLocomotionState { get; set; }

		public LocomotionSceneInitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
