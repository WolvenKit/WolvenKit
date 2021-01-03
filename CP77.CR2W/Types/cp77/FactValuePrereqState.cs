using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FactValuePrereqState : gamePrereqState
	{
		[Ordinal(0)]  [RED("listenerID")] public CUInt32 ListenerID { get; set; }

		public FactValuePrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
