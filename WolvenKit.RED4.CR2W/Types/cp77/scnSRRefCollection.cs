using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSRRefCollection : CVariable
	{
		private CArray<scnRidAnimationSRRef> _ridAnimations;
		private CArray<scnRidAnimSetSRRef> _ridAnimSets;
		private CArray<scnRidAnimSetSRRef> _ridFacialAnimSets;
		private CArray<scnRidAnimSetSRRef> _ridCyberwareAnimSets;
		private CArray<scnRidAnimSetSRRef> _ridDeformationAnimSets;
		private CArray<scnLipsyncAnimSetSRRef> _lipsyncAnimSets;
		private CArray<scnRidCameraAnimationSRRef> _ridCameraAnimations;
		private CArray<scnCinematicAnimSetSRRef> _cinematicAnimSets;
		private CArray<scnGameplayAnimSetSRRef> _gameplayAnimSets;
		private CArray<scnDynamicAnimSetSRRef> _dynamicAnimSets;
		private CArray<scnAnimSetAnimNames> _cinematicAnimNames;
		private CArray<scnAnimSetAnimNames> _gameplayAnimNames;
		private CArray<scnAnimSetDynAnimNames> _dynamicAnimNames;
		private CArray<scnRidAnimationContainerSRRef> _ridAnimationContainers;

		[Ordinal(0)] 
		[RED("ridAnimations")] 
		public CArray<scnRidAnimationSRRef> RidAnimations
		{
			get
			{
				if (_ridAnimations == null)
				{
					_ridAnimations = (CArray<scnRidAnimationSRRef>) CR2WTypeManager.Create("array:scnRidAnimationSRRef", "ridAnimations", cr2w, this);
				}
				return _ridAnimations;
			}
			set
			{
				if (_ridAnimations == value)
				{
					return;
				}
				_ridAnimations = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ridAnimSets")] 
		public CArray<scnRidAnimSetSRRef> RidAnimSets
		{
			get
			{
				if (_ridAnimSets == null)
				{
					_ridAnimSets = (CArray<scnRidAnimSetSRRef>) CR2WTypeManager.Create("array:scnRidAnimSetSRRef", "ridAnimSets", cr2w, this);
				}
				return _ridAnimSets;
			}
			set
			{
				if (_ridAnimSets == value)
				{
					return;
				}
				_ridAnimSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ridFacialAnimSets")] 
		public CArray<scnRidAnimSetSRRef> RidFacialAnimSets
		{
			get
			{
				if (_ridFacialAnimSets == null)
				{
					_ridFacialAnimSets = (CArray<scnRidAnimSetSRRef>) CR2WTypeManager.Create("array:scnRidAnimSetSRRef", "ridFacialAnimSets", cr2w, this);
				}
				return _ridFacialAnimSets;
			}
			set
			{
				if (_ridFacialAnimSets == value)
				{
					return;
				}
				_ridFacialAnimSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ridCyberwareAnimSets")] 
		public CArray<scnRidAnimSetSRRef> RidCyberwareAnimSets
		{
			get
			{
				if (_ridCyberwareAnimSets == null)
				{
					_ridCyberwareAnimSets = (CArray<scnRidAnimSetSRRef>) CR2WTypeManager.Create("array:scnRidAnimSetSRRef", "ridCyberwareAnimSets", cr2w, this);
				}
				return _ridCyberwareAnimSets;
			}
			set
			{
				if (_ridCyberwareAnimSets == value)
				{
					return;
				}
				_ridCyberwareAnimSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ridDeformationAnimSets")] 
		public CArray<scnRidAnimSetSRRef> RidDeformationAnimSets
		{
			get
			{
				if (_ridDeformationAnimSets == null)
				{
					_ridDeformationAnimSets = (CArray<scnRidAnimSetSRRef>) CR2WTypeManager.Create("array:scnRidAnimSetSRRef", "ridDeformationAnimSets", cr2w, this);
				}
				return _ridDeformationAnimSets;
			}
			set
			{
				if (_ridDeformationAnimSets == value)
				{
					return;
				}
				_ridDeformationAnimSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("lipsyncAnimSets")] 
		public CArray<scnLipsyncAnimSetSRRef> LipsyncAnimSets
		{
			get
			{
				if (_lipsyncAnimSets == null)
				{
					_lipsyncAnimSets = (CArray<scnLipsyncAnimSetSRRef>) CR2WTypeManager.Create("array:scnLipsyncAnimSetSRRef", "lipsyncAnimSets", cr2w, this);
				}
				return _lipsyncAnimSets;
			}
			set
			{
				if (_lipsyncAnimSets == value)
				{
					return;
				}
				_lipsyncAnimSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("ridCameraAnimations")] 
		public CArray<scnRidCameraAnimationSRRef> RidCameraAnimations
		{
			get
			{
				if (_ridCameraAnimations == null)
				{
					_ridCameraAnimations = (CArray<scnRidCameraAnimationSRRef>) CR2WTypeManager.Create("array:scnRidCameraAnimationSRRef", "ridCameraAnimations", cr2w, this);
				}
				return _ridCameraAnimations;
			}
			set
			{
				if (_ridCameraAnimations == value)
				{
					return;
				}
				_ridCameraAnimations = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("cinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRef> CinematicAnimSets
		{
			get
			{
				if (_cinematicAnimSets == null)
				{
					_cinematicAnimSets = (CArray<scnCinematicAnimSetSRRef>) CR2WTypeManager.Create("array:scnCinematicAnimSetSRRef", "cinematicAnimSets", cr2w, this);
				}
				return _cinematicAnimSets;
			}
			set
			{
				if (_cinematicAnimSets == value)
				{
					return;
				}
				_cinematicAnimSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("gameplayAnimSets")] 
		public CArray<scnGameplayAnimSetSRRef> GameplayAnimSets
		{
			get
			{
				if (_gameplayAnimSets == null)
				{
					_gameplayAnimSets = (CArray<scnGameplayAnimSetSRRef>) CR2WTypeManager.Create("array:scnGameplayAnimSetSRRef", "gameplayAnimSets", cr2w, this);
				}
				return _gameplayAnimSets;
			}
			set
			{
				if (_gameplayAnimSets == value)
				{
					return;
				}
				_gameplayAnimSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("dynamicAnimSets")] 
		public CArray<scnDynamicAnimSetSRRef> DynamicAnimSets
		{
			get
			{
				if (_dynamicAnimSets == null)
				{
					_dynamicAnimSets = (CArray<scnDynamicAnimSetSRRef>) CR2WTypeManager.Create("array:scnDynamicAnimSetSRRef", "dynamicAnimSets", cr2w, this);
				}
				return _dynamicAnimSets;
			}
			set
			{
				if (_dynamicAnimSets == value)
				{
					return;
				}
				_dynamicAnimSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("cinematicAnimNames")] 
		public CArray<scnAnimSetAnimNames> CinematicAnimNames
		{
			get
			{
				if (_cinematicAnimNames == null)
				{
					_cinematicAnimNames = (CArray<scnAnimSetAnimNames>) CR2WTypeManager.Create("array:scnAnimSetAnimNames", "cinematicAnimNames", cr2w, this);
				}
				return _cinematicAnimNames;
			}
			set
			{
				if (_cinematicAnimNames == value)
				{
					return;
				}
				_cinematicAnimNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("gameplayAnimNames")] 
		public CArray<scnAnimSetAnimNames> GameplayAnimNames
		{
			get
			{
				if (_gameplayAnimNames == null)
				{
					_gameplayAnimNames = (CArray<scnAnimSetAnimNames>) CR2WTypeManager.Create("array:scnAnimSetAnimNames", "gameplayAnimNames", cr2w, this);
				}
				return _gameplayAnimNames;
			}
			set
			{
				if (_gameplayAnimNames == value)
				{
					return;
				}
				_gameplayAnimNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("dynamicAnimNames")] 
		public CArray<scnAnimSetDynAnimNames> DynamicAnimNames
		{
			get
			{
				if (_dynamicAnimNames == null)
				{
					_dynamicAnimNames = (CArray<scnAnimSetDynAnimNames>) CR2WTypeManager.Create("array:scnAnimSetDynAnimNames", "dynamicAnimNames", cr2w, this);
				}
				return _dynamicAnimNames;
			}
			set
			{
				if (_dynamicAnimNames == value)
				{
					return;
				}
				_dynamicAnimNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("ridAnimationContainers")] 
		public CArray<scnRidAnimationContainerSRRef> RidAnimationContainers
		{
			get
			{
				if (_ridAnimationContainers == null)
				{
					_ridAnimationContainers = (CArray<scnRidAnimationContainerSRRef>) CR2WTypeManager.Create("array:scnRidAnimationContainerSRRef", "ridAnimationContainers", cr2w, this);
				}
				return _ridAnimationContainers;
			}
			set
			{
				if (_ridAnimationContainers == value)
				{
					return;
				}
				_ridAnimationContainers = value;
				PropertySet(this);
			}
		}

		public scnSRRefCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
