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
			get
			{
				if (_puppets == null)
				{
					_puppets = (CBool) CR2WTypeManager.Create("Bool", "puppets", cr2w, this);
				}
				return _puppets;
			}
			set
			{
				if (_puppets == value)
				{
					return;
				}
				_puppets = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("gameObjects")] 
		public CBool GameObjects
		{
			get
			{
				if (_gameObjects == null)
				{
					_gameObjects = (CBool) CR2WTypeManager.Create("Bool", "gameObjects", cr2w, this);
				}
				return _gameObjects;
			}
			set
			{
				if (_gameObjects == value)
				{
					return;
				}
				_gameObjects = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("destructibleAndDynamic")] 
		public CBool DestructibleAndDynamic
		{
			get
			{
				if (_destructibleAndDynamic == null)
				{
					_destructibleAndDynamic = (CBool) CR2WTypeManager.Create("Bool", "destructibleAndDynamic", cr2w, this);
				}
				return _destructibleAndDynamic;
			}
			set
			{
				if (_destructibleAndDynamic == value)
				{
					return;
				}
				_destructibleAndDynamic = value;
				PropertySet(this);
			}
		}

		public gameEffectObjectProvider_Explosion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
