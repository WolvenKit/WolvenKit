using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SampleCounterDisplayComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("targetPersistentID")] public gamePersistentID TargetPersistentID { get; set; }

		public SampleCounterDisplayComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
