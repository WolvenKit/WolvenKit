using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SParticleEmitterLODLevel : CVariable
	{
		private EmitterDurationSettings _emitterDurationSettings;
		private EmitterDelaySettings _emitterDelaySettings;
		private CArray<ParticleBurst> _burstList;
		private CHandle<IEvaluatorFloat> _birthRate;
		private CEnum<rendEParticleSortingMode> _sortingMode;
		private CFloat _lodSwitchDistance;
		private CBool _isEnabled;

		[Ordinal(0)] 
		[RED("emitterDurationSettings")] 
		public EmitterDurationSettings EmitterDurationSettings
		{
			get
			{
				if (_emitterDurationSettings == null)
				{
					_emitterDurationSettings = (EmitterDurationSettings) CR2WTypeManager.Create("EmitterDurationSettings", "emitterDurationSettings", cr2w, this);
				}
				return _emitterDurationSettings;
			}
			set
			{
				if (_emitterDurationSettings == value)
				{
					return;
				}
				_emitterDurationSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("emitterDelaySettings")] 
		public EmitterDelaySettings EmitterDelaySettings
		{
			get
			{
				if (_emitterDelaySettings == null)
				{
					_emitterDelaySettings = (EmitterDelaySettings) CR2WTypeManager.Create("EmitterDelaySettings", "emitterDelaySettings", cr2w, this);
				}
				return _emitterDelaySettings;
			}
			set
			{
				if (_emitterDelaySettings == value)
				{
					return;
				}
				_emitterDelaySettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("burstList")] 
		public CArray<ParticleBurst> BurstList
		{
			get
			{
				if (_burstList == null)
				{
					_burstList = (CArray<ParticleBurst>) CR2WTypeManager.Create("array:ParticleBurst", "burstList", cr2w, this);
				}
				return _burstList;
			}
			set
			{
				if (_burstList == value)
				{
					return;
				}
				_burstList = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("birthRate")] 
		public CHandle<IEvaluatorFloat> BirthRate
		{
			get
			{
				if (_birthRate == null)
				{
					_birthRate = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "birthRate", cr2w, this);
				}
				return _birthRate;
			}
			set
			{
				if (_birthRate == value)
				{
					return;
				}
				_birthRate = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("sortingMode")] 
		public CEnum<rendEParticleSortingMode> SortingMode
		{
			get
			{
				if (_sortingMode == null)
				{
					_sortingMode = (CEnum<rendEParticleSortingMode>) CR2WTypeManager.Create("rendEParticleSortingMode", "sortingMode", cr2w, this);
				}
				return _sortingMode;
			}
			set
			{
				if (_sortingMode == value)
				{
					return;
				}
				_sortingMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("lodSwitchDistance")] 
		public CFloat LodSwitchDistance
		{
			get
			{
				if (_lodSwitchDistance == null)
				{
					_lodSwitchDistance = (CFloat) CR2WTypeManager.Create("Float", "lodSwitchDistance", cr2w, this);
				}
				return _lodSwitchDistance;
			}
			set
			{
				if (_lodSwitchDistance == value)
				{
					return;
				}
				_lodSwitchDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		public SParticleEmitterLODLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
