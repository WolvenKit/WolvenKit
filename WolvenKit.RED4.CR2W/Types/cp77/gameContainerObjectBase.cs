using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameContainerObjectBase : gameLootContainerBase
	{
		[Ordinal(50)] [RED("lockedByKey")] public TweakDBID LockedByKey { get; set; }

		public gameContainerObjectBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
