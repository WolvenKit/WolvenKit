using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePhantomEntityParameters : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("teleportStartEffect")] 
		public CName TeleportStartEffect
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("teleportEndEffect")] 
		public CName TeleportEndEffect
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("spawnEffect")] 
		public CName SpawnEffect
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("glitchEffect")] 
		public CName GlitchEffect
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("phantomVisibleStates")] 
		public CArray<CEnum<gamePhantomEntityState>> PhantomVisibleStates
		{
			get => GetPropertyValue<CArray<CEnum<gamePhantomEntityState>>>();
			set => SetPropertyValue<CArray<CEnum<gamePhantomEntityState>>>(value);
		}

		[Ordinal(5)] 
		[RED("blendableAppearanceMatches")] 
		public CArray<gamePhantomEntityParametersBlendableAppearanceMatch> BlendableAppearanceMatches
		{
			get => GetPropertyValue<CArray<gamePhantomEntityParametersBlendableAppearanceMatch>>();
			set => SetPropertyValue<CArray<gamePhantomEntityParametersBlendableAppearanceMatch>>(value);
		}

		public gamePhantomEntityParameters()
		{
			PhantomVisibleStates = new() { Enums.gamePhantomEntityState.RootMotion, Enums.gamePhantomEntityState.Workspot };
			BlendableAppearanceMatches = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
