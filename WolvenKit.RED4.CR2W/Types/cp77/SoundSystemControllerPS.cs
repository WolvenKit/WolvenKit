using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SoundSystemControllerPS : MasterControllerPS
	{
		[Ordinal(104)] [RED("defaultAction")] public CInt32 DefaultAction { get; set; }
		[Ordinal(105)] [RED("soundSystemSettings")] public CArray<SoundSystemSettings> SoundSystemSettings { get; set; }
		[Ordinal(106)] [RED("currentEvent")] public CHandle<ChangeMusicAction> CurrentEvent { get; set; }
		[Ordinal(107)] [RED("cachedEvent")] public CHandle<ChangeMusicAction> CachedEvent { get; set; }

		public SoundSystemControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
