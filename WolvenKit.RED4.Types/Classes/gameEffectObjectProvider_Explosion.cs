using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectProvider_Explosion : gameEffectObjectProvider
	{
		private CBool _puppets;
		private CBool _gameObjects;
		private CBool _destructibleAndDynamic;

		[Ordinal(0)] 
		[RED("puppets")] 
		public CBool Puppets
		{
			get => GetProperty(ref _puppets);
			set => SetProperty(ref _puppets, value);
		}

		[Ordinal(1)] 
		[RED("gameObjects")] 
		public CBool GameObjects
		{
			get => GetProperty(ref _gameObjects);
			set => SetProperty(ref _gameObjects, value);
		}

		[Ordinal(2)] 
		[RED("destructibleAndDynamic")] 
		public CBool DestructibleAndDynamic
		{
			get => GetProperty(ref _destructibleAndDynamic);
			set => SetProperty(ref _destructibleAndDynamic, value);
		}

		public gameEffectObjectProvider_Explosion()
		{
			_puppets = true;
			_gameObjects = true;
			_destructibleAndDynamic = true;
		}
	}
}
