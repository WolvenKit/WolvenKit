using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHACK_UseSensePresetEvent : redEvent
	{
		[Ordinal(0)] [RED("sensePreset")] public TweakDBID SensePreset { get; set; }

		public gameHACK_UseSensePresetEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
