using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioGrenadeEntitySettings : audioEntitySettings
	{
		[Ordinal(6)] [RED("explosionSound")] public CName ExplosionSound { get; set; }

		public audioGrenadeEntitySettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
