using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectProvider_Explosion : gameEffectObjectProvider
	{
		[Ordinal(0)] 
		[RED("puppets")] 
		public CBool Puppets
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("gameObjects")] 
		public CBool GameObjects
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("destructibleAndDynamic")] 
		public CBool DestructibleAndDynamic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEffectObjectProvider_Explosion()
		{
			Puppets = true;
			GameObjects = true;
			DestructibleAndDynamic = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
