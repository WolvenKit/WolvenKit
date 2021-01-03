using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CoopIrritationDelayCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)]  [RED("companion")] public wCHandle<gameObject> Companion { get; set; }

		public CoopIrritationDelayCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
