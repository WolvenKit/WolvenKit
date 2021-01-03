using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LocomotionSceneInitData : IScriptable
	{
		[Ordinal(0)]  [RED("previousLocomotionState")] public CInt32 PreviousLocomotionState { get; set; }

		public LocomotionSceneInitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
