using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExplosiveDeviceControllerPS : BasicDistractionDeviceControllerPS
	{
		private CHandle<EngDemoContainer> _explosiveSkillChecks;
		private CArray<ExplosiveDeviceResourceDefinition> _explosionDefinition;
		private CBool _explosiveWithQhacks;
		private CFloat _healthDecay;
		private CFloat _timeToMeshSwap;
		private CBool _shouldDistractionHitVFXIgnoreHitPosition;
		private CBool _canBeDisabledWithQhacks;
		private CBool _disarmed;
		private CBool _exploded;
		private CBool _provideExplodeAction;
		private CBool _doExplosiveEngineerLogic;

		[Ordinal(108)] 
		[RED("explosiveSkillChecks")] 
		public CHandle<EngDemoContainer> ExplosiveSkillChecks
		{
			get
			{
				if (_explosiveSkillChecks == null)
				{
					_explosiveSkillChecks = (CHandle<EngDemoContainer>) CR2WTypeManager.Create("handle:EngDemoContainer", "explosiveSkillChecks", cr2w, this);
				}
				return _explosiveSkillChecks;
			}
			set
			{
				if (_explosiveSkillChecks == value)
				{
					return;
				}
				_explosiveSkillChecks = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("explosionDefinition")] 
		public CArray<ExplosiveDeviceResourceDefinition> ExplosionDefinition
		{
			get
			{
				if (_explosionDefinition == null)
				{
					_explosionDefinition = (CArray<ExplosiveDeviceResourceDefinition>) CR2WTypeManager.Create("array:ExplosiveDeviceResourceDefinition", "explosionDefinition", cr2w, this);
				}
				return _explosionDefinition;
			}
			set
			{
				if (_explosionDefinition == value)
				{
					return;
				}
				_explosionDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(110)] 
		[RED("explosiveWithQhacks")] 
		public CBool ExplosiveWithQhacks
		{
			get
			{
				if (_explosiveWithQhacks == null)
				{
					_explosiveWithQhacks = (CBool) CR2WTypeManager.Create("Bool", "explosiveWithQhacks", cr2w, this);
				}
				return _explosiveWithQhacks;
			}
			set
			{
				if (_explosiveWithQhacks == value)
				{
					return;
				}
				_explosiveWithQhacks = value;
				PropertySet(this);
			}
		}

		[Ordinal(111)] 
		[RED("HealthDecay")] 
		public CFloat HealthDecay
		{
			get
			{
				if (_healthDecay == null)
				{
					_healthDecay = (CFloat) CR2WTypeManager.Create("Float", "HealthDecay", cr2w, this);
				}
				return _healthDecay;
			}
			set
			{
				if (_healthDecay == value)
				{
					return;
				}
				_healthDecay = value;
				PropertySet(this);
			}
		}

		[Ordinal(112)] 
		[RED("timeToMeshSwap")] 
		public CFloat TimeToMeshSwap
		{
			get
			{
				if (_timeToMeshSwap == null)
				{
					_timeToMeshSwap = (CFloat) CR2WTypeManager.Create("Float", "timeToMeshSwap", cr2w, this);
				}
				return _timeToMeshSwap;
			}
			set
			{
				if (_timeToMeshSwap == value)
				{
					return;
				}
				_timeToMeshSwap = value;
				PropertySet(this);
			}
		}

		[Ordinal(113)] 
		[RED("shouldDistractionHitVFXIgnoreHitPosition")] 
		public CBool ShouldDistractionHitVFXIgnoreHitPosition
		{
			get
			{
				if (_shouldDistractionHitVFXIgnoreHitPosition == null)
				{
					_shouldDistractionHitVFXIgnoreHitPosition = (CBool) CR2WTypeManager.Create("Bool", "shouldDistractionHitVFXIgnoreHitPosition", cr2w, this);
				}
				return _shouldDistractionHitVFXIgnoreHitPosition;
			}
			set
			{
				if (_shouldDistractionHitVFXIgnoreHitPosition == value)
				{
					return;
				}
				_shouldDistractionHitVFXIgnoreHitPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(114)] 
		[RED("canBeDisabledWithQhacks")] 
		public CBool CanBeDisabledWithQhacks
		{
			get
			{
				if (_canBeDisabledWithQhacks == null)
				{
					_canBeDisabledWithQhacks = (CBool) CR2WTypeManager.Create("Bool", "canBeDisabledWithQhacks", cr2w, this);
				}
				return _canBeDisabledWithQhacks;
			}
			set
			{
				if (_canBeDisabledWithQhacks == value)
				{
					return;
				}
				_canBeDisabledWithQhacks = value;
				PropertySet(this);
			}
		}

		[Ordinal(115)] 
		[RED("disarmed")] 
		public CBool Disarmed
		{
			get
			{
				if (_disarmed == null)
				{
					_disarmed = (CBool) CR2WTypeManager.Create("Bool", "disarmed", cr2w, this);
				}
				return _disarmed;
			}
			set
			{
				if (_disarmed == value)
				{
					return;
				}
				_disarmed = value;
				PropertySet(this);
			}
		}

		[Ordinal(116)] 
		[RED("exploded")] 
		public CBool Exploded
		{
			get
			{
				if (_exploded == null)
				{
					_exploded = (CBool) CR2WTypeManager.Create("Bool", "exploded", cr2w, this);
				}
				return _exploded;
			}
			set
			{
				if (_exploded == value)
				{
					return;
				}
				_exploded = value;
				PropertySet(this);
			}
		}

		[Ordinal(117)] 
		[RED("provideExplodeAction")] 
		public CBool ProvideExplodeAction
		{
			get
			{
				if (_provideExplodeAction == null)
				{
					_provideExplodeAction = (CBool) CR2WTypeManager.Create("Bool", "provideExplodeAction", cr2w, this);
				}
				return _provideExplodeAction;
			}
			set
			{
				if (_provideExplodeAction == value)
				{
					return;
				}
				_provideExplodeAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(118)] 
		[RED("doExplosiveEngineerLogic")] 
		public CBool DoExplosiveEngineerLogic
		{
			get
			{
				if (_doExplosiveEngineerLogic == null)
				{
					_doExplosiveEngineerLogic = (CBool) CR2WTypeManager.Create("Bool", "doExplosiveEngineerLogic", cr2w, this);
				}
				return _doExplosiveEngineerLogic;
			}
			set
			{
				if (_doExplosiveEngineerLogic == value)
				{
					return;
				}
				_doExplosiveEngineerLogic = value;
				PropertySet(this);
			}
		}

		public ExplosiveDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
