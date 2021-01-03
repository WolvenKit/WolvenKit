using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MoveToCoverCommandTask : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("coverID")] public CUInt64 CoverID { get; set; }
		[Ordinal(1)]  [RED("currentCommand")] public wCHandle<AIMoveToCoverCommand> CurrentCommand { get; set; }
		[Ordinal(2)]  [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }

		public MoveToCoverCommandTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
