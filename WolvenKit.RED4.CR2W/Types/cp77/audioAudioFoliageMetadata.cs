using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioFoliageMetadata : audioAudioMetadata
	{
		private CName _loopStartEvent;
		private CName _loopStopEvent;
		private CName _locomotionTotalVelocityParam;
		private CFloat _locomotionTotalVelocityThreshold;
		private CFloat _locomotionAngularVelocityMultiplier;
		private CFloat _minFoliageMeshVolumeThreshold;
		private CFloat _maxFoliageMeshHeight;
		private CFloat _playerInsideRequiredPercentage;
		private CHandle<audioAudioFoliageMaterialDictionary> _foliageMaterials;

		[Ordinal(1)] 
		[RED("loopStartEvent")] 
		public CName LoopStartEvent
		{
			get
			{
				if (_loopStartEvent == null)
				{
					_loopStartEvent = (CName) CR2WTypeManager.Create("CName", "loopStartEvent", cr2w, this);
				}
				return _loopStartEvent;
			}
			set
			{
				if (_loopStartEvent == value)
				{
					return;
				}
				_loopStartEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("loopStopEvent")] 
		public CName LoopStopEvent
		{
			get
			{
				if (_loopStopEvent == null)
				{
					_loopStopEvent = (CName) CR2WTypeManager.Create("CName", "loopStopEvent", cr2w, this);
				}
				return _loopStopEvent;
			}
			set
			{
				if (_loopStopEvent == value)
				{
					return;
				}
				_loopStopEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("locomotionTotalVelocityParam")] 
		public CName LocomotionTotalVelocityParam
		{
			get
			{
				if (_locomotionTotalVelocityParam == null)
				{
					_locomotionTotalVelocityParam = (CName) CR2WTypeManager.Create("CName", "locomotionTotalVelocityParam", cr2w, this);
				}
				return _locomotionTotalVelocityParam;
			}
			set
			{
				if (_locomotionTotalVelocityParam == value)
				{
					return;
				}
				_locomotionTotalVelocityParam = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("locomotionTotalVelocityThreshold")] 
		public CFloat LocomotionTotalVelocityThreshold
		{
			get
			{
				if (_locomotionTotalVelocityThreshold == null)
				{
					_locomotionTotalVelocityThreshold = (CFloat) CR2WTypeManager.Create("Float", "locomotionTotalVelocityThreshold", cr2w, this);
				}
				return _locomotionTotalVelocityThreshold;
			}
			set
			{
				if (_locomotionTotalVelocityThreshold == value)
				{
					return;
				}
				_locomotionTotalVelocityThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("locomotionAngularVelocityMultiplier")] 
		public CFloat LocomotionAngularVelocityMultiplier
		{
			get
			{
				if (_locomotionAngularVelocityMultiplier == null)
				{
					_locomotionAngularVelocityMultiplier = (CFloat) CR2WTypeManager.Create("Float", "locomotionAngularVelocityMultiplier", cr2w, this);
				}
				return _locomotionAngularVelocityMultiplier;
			}
			set
			{
				if (_locomotionAngularVelocityMultiplier == value)
				{
					return;
				}
				_locomotionAngularVelocityMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("minFoliageMeshVolumeThreshold")] 
		public CFloat MinFoliageMeshVolumeThreshold
		{
			get
			{
				if (_minFoliageMeshVolumeThreshold == null)
				{
					_minFoliageMeshVolumeThreshold = (CFloat) CR2WTypeManager.Create("Float", "minFoliageMeshVolumeThreshold", cr2w, this);
				}
				return _minFoliageMeshVolumeThreshold;
			}
			set
			{
				if (_minFoliageMeshVolumeThreshold == value)
				{
					return;
				}
				_minFoliageMeshVolumeThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("maxFoliageMeshHeight")] 
		public CFloat MaxFoliageMeshHeight
		{
			get
			{
				if (_maxFoliageMeshHeight == null)
				{
					_maxFoliageMeshHeight = (CFloat) CR2WTypeManager.Create("Float", "maxFoliageMeshHeight", cr2w, this);
				}
				return _maxFoliageMeshHeight;
			}
			set
			{
				if (_maxFoliageMeshHeight == value)
				{
					return;
				}
				_maxFoliageMeshHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("playerInsideRequiredPercentage")] 
		public CFloat PlayerInsideRequiredPercentage
		{
			get
			{
				if (_playerInsideRequiredPercentage == null)
				{
					_playerInsideRequiredPercentage = (CFloat) CR2WTypeManager.Create("Float", "playerInsideRequiredPercentage", cr2w, this);
				}
				return _playerInsideRequiredPercentage;
			}
			set
			{
				if (_playerInsideRequiredPercentage == value)
				{
					return;
				}
				_playerInsideRequiredPercentage = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("foliageMaterials")] 
		public CHandle<audioAudioFoliageMaterialDictionary> FoliageMaterials
		{
			get
			{
				if (_foliageMaterials == null)
				{
					_foliageMaterials = (CHandle<audioAudioFoliageMaterialDictionary>) CR2WTypeManager.Create("handle:audioAudioFoliageMaterialDictionary", "foliageMaterials", cr2w, this);
				}
				return _foliageMaterials;
			}
			set
			{
				if (_foliageMaterials == value)
				{
					return;
				}
				_foliageMaterials = value;
				PropertySet(this);
			}
		}

		public audioAudioFoliageMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
