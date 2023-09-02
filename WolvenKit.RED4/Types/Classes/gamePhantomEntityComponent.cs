using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePhantomEntityComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("params")] 
		public gamePhantomEntityParameters Params
		{
			get => GetPropertyValue<gamePhantomEntityParameters>();
			set => SetPropertyValue<gamePhantomEntityParameters>(value);
		}

		[Ordinal(4)] 
		[RED("effectBinding")] 
		public CHandle<gameEffectComponentBinding> EffectBinding
		{
			get => GetPropertyValue<CHandle<gameEffectComponentBinding>>();
			set => SetPropertyValue<CHandle<gameEffectComponentBinding>>(value);
		}

		public gamePhantomEntityComponent()
		{
			Name = "Component";
			Params = new gamePhantomEntityParameters { BlendableAppearanceMatches = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
