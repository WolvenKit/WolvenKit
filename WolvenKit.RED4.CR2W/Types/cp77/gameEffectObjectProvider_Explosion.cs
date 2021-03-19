using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_Explosion : gameEffectObjectProvider
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

		public gameEffectObjectProvider_Explosion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
