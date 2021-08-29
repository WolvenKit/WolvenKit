using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePhantomEntityParameters : RedBaseClass
	{
		private CName _teleportStartEffect;
		private CName _teleportEndEffect;
		private CName _spawnEffect;
		private CName _glitchEffect;
		private CArray<gamePhantomEntityParametersBlendableAppearanceMatch> _blendableAppearanceMatches;

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

		[Ordinal(4)] 
		[RED("blendableAppearanceMatches")] 
		public CArray<gamePhantomEntityParametersBlendableAppearanceMatch> BlendableAppearanceMatches
		{
			get => GetProperty(ref _blendableAppearanceMatches);
			set => SetProperty(ref _blendableAppearanceMatches, value);
		}
	}
}
