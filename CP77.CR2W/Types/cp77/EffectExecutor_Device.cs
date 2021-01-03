using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_Device : gameEffectExecutor_Scripted
	{
		[Ordinal(0)]  [RED("maxDelay")] public CFloat MaxDelay { get; set; }

		public EffectExecutor_Device(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
