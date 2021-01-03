using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameContainerObjectBase : gameLootContainerBase
	{
		[Ordinal(0)]  [RED("lockedByKey")] public TweakDBID LockedByKey { get; set; }

		public gameContainerObjectBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
