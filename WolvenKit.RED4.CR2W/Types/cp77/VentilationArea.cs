using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VentilationArea : InteractiveMasterDevice
	{
		private CHandle<gameStaticTriggerAreaComponent> _areaComponent;
		private CBool _restartGameEffectOnAttach;
		private CString _attackRecord;
		private gameEffectRef _gameEffectRef;
		private CHandle<gameEffectInstance> _gameEffect;
		private CBool _highLightActive;

		[Ordinal(93)] 
		[RED("areaComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> AreaComponent
		{
			get
			{
				if (_areaComponent == null)
				{
					_areaComponent = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "areaComponent", cr2w, this);
				}
				return _areaComponent;
			}
			set
			{
				if (_areaComponent == value)
				{
					return;
				}
				_areaComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("RestartGameEffectOnAttach")] 
		public CBool RestartGameEffectOnAttach
		{
			get
			{
				if (_restartGameEffectOnAttach == null)
				{
					_restartGameEffectOnAttach = (CBool) CR2WTypeManager.Create("Bool", "RestartGameEffectOnAttach", cr2w, this);
				}
				return _restartGameEffectOnAttach;
			}
			set
			{
				if (_restartGameEffectOnAttach == value)
				{
					return;
				}
				_restartGameEffectOnAttach = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("AttackRecord")] 
		public CString AttackRecord
		{
			get
			{
				if (_attackRecord == null)
				{
					_attackRecord = (CString) CR2WTypeManager.Create("String", "AttackRecord", cr2w, this);
				}
				return _attackRecord;
			}
			set
			{
				if (_attackRecord == value)
				{
					return;
				}
				_attackRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
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

		[Ordinal(97)] 
		[RED("gameEffect")] 
		public CHandle<gameEffectInstance> GameEffect
		{
			get
			{
				if (_gameEffect == null)
				{
					_gameEffect = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "gameEffect", cr2w, this);
				}
				return _gameEffect;
			}
			set
			{
				if (_gameEffect == value)
				{
					return;
				}
				_gameEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("highLightActive")] 
		public CBool HighLightActive
		{
			get
			{
				if (_highLightActive == null)
				{
					_highLightActive = (CBool) CR2WTypeManager.Create("Bool", "highLightActive", cr2w, this);
				}
				return _highLightActive;
			}
			set
			{
				if (_highLightActive == value)
				{
					return;
				}
				_highLightActive = value;
				PropertySet(this);
			}
		}

		public VentilationArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
