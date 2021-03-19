using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePhantomEntityParameters : CVariable
	{
		private CName _teleportStartEffect;
		private CName _teleportEndEffect;
		private CName _spawnEffect;
		private CName _glitchEffect;

		[Ordinal(0)] 
		[RED("teleportStartEffect")] 
		public CName TeleportStartEffect
		{
			get => GetProperty(ref _teleportStartEffect);
			set => SetProperty(ref _teleportStartEffect, value);
		}

		[Ordinal(1)] 
		[RED("teleportEndEffect")] 
		public CName TeleportEndEffect
		{
			get => GetProperty(ref _teleportEndEffect);
			set => SetProperty(ref _teleportEndEffect, value);
		}

		[Ordinal(2)] 
		[RED("spawnEffect")] 
		public CName SpawnEffect
		{
			get => GetProperty(ref _spawnEffect);
			set => SetProperty(ref _spawnEffect, value);
		}

		[Ordinal(3)] 
		[RED("glitchEffect")] 
		public CName GlitchEffect
		{
			get => GetProperty(ref _glitchEffect);
			set => SetProperty(ref _glitchEffect, value);
		}

		public gamePhantomEntityParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
