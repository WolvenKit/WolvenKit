using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioGrenadeEntitySettings : audioEntitySettings
	{
		private CName _explosionSound;

		[Ordinal(6)] 
		[RED("explosionSound")] 
		public CName ExplosionSound
		{
			get => GetProperty(ref _explosionSound);
			set => SetProperty(ref _explosionSound, value);
		}

		public audioGrenadeEntitySettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
