using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FunctionalTestsTimeChangeEvent : redEvent
	{
		[Ordinal(0)]  [RED("listenerId")] public CUInt32 ListenerId { get; set; }

		public FunctionalTestsTimeChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
