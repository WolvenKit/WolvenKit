using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SoundSystemControllerPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("cachedEvent")] public CHandle<ChangeMusicAction> CachedEvent { get; set; }
		[Ordinal(1)]  [RED("currentEvent")] public CHandle<ChangeMusicAction> CurrentEvent { get; set; }
		[Ordinal(2)]  [RED("defaultAction")] public CInt32 DefaultAction { get; set; }
		[Ordinal(3)]  [RED("soundSystemSettings")] public CArray<SoundSystemSettings> SoundSystemSettings { get; set; }

		public SoundSystemControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
