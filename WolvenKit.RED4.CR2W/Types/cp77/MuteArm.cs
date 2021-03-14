using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MuteArm : gameweaponObject
	{
		private gameEffectRef _gameEffectRef;
		private CHandle<gameEffectInstance> _gameEffectInstance;

		[Ordinal(57)] 
		[RED("gameEffectRef")] 
		public gameEffectRef GameEffectRef
		{
			get
			{
				if (_gameEffectRef == null)
				{
					_gameEffectRef = (gameEffectRef) CR2WTypeManager.Create("gameEffectRef", "gameEffectRef", cr2w, this);
				}
				return _gameEffectRef;
			}
			set
			{
				if (_gameEffectRef == value)
				{
					return;
				}
				_gameEffectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("gameEffectInstance")] 
		public CHandle<gameEffectInstance> GameEffectInstance
		{
			get
			{
				if (_gameEffectInstance == null)
				{
					_gameEffectInstance = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "gameEffectInstance", cr2w, this);
				}
				return _gameEffectInstance;
			}
			set
			{
				if (_gameEffectInstance == value)
				{
					return;
				}
				_gameEffectInstance = value;
				PropertySet(this);
			}
		}

		public MuteArm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
