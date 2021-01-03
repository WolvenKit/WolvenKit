using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FocusModeTaggingSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("playerAttachedCallbackID")] public CUInt32 PlayerAttachedCallbackID { get; set; }
		[Ordinal(1)]  [RED("playerDetachedCallbackID")] public CUInt32 PlayerDetachedCallbackID { get; set; }

		public FocusModeTaggingSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
