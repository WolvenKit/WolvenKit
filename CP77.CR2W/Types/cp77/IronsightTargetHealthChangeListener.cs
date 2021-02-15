using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IronsightTargetHealthChangeListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] [RED("parentIronsight")] public wCHandle<IronsightGameController> ParentIronsight { get; set; }

		public IronsightTargetHealthChangeListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
