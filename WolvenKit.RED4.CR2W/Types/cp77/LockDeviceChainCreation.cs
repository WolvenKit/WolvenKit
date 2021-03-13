using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LockDeviceChainCreation : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("isLocked")] public CBool IsLocked { get; set; }
		[Ordinal(1)] [RED("source")] public CName Source { get; set; }

		public LockDeviceChainCreation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
