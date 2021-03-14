using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAcousticsEmitterMetadata : audioEmitterMetadata
	{
		private CBool _obstuctionEnabled;
		private CBool _occlusionEnabled;
		private CBool _repositioningEnabled;
		private CFloat _obstructionFadeTime;
		private CBool _enableOutdoorness;
		private CBool _postDopplerFactor;
		private CName _dopplerParameter;
		private CFloat _ignoreOcclusionRadius;
		private CBool _elevateSource;

		[Ordinal(1)] 
		[RED("obstuctionEnabled")] 
		public CBool ObstuctionEnabled
		{
			get
			{
				if (_obstuctionEnabled == null)
				{
					_obstuctionEnabled = (CBool) CR2WTypeManager.Create("Bool", "obstuctionEnabled", cr2w, this);
				}
				return _obstuctionEnabled;
			}
			set
			{
				if (_obstuctionEnabled == value)
				{
					return;
				}
				_obstuctionEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("occlusionEnabled")] 
		public CBool OcclusionEnabled
		{
			get
			{
				if (_occlusionEnabled == null)
				{
					_occlusionEnabled = (CBool) CR2WTypeManager.Create("Bool", "occlusionEnabled", cr2w, this);
				}
				return _occlusionEnabled;
			}
			set
			{
				if (_occlusionEnabled == value)
				{
					return;
				}
				_occlusionEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("repositioningEnabled")] 
		public CBool RepositioningEnabled
		{
			get
			{
				if (_repositioningEnabled == null)
				{
					_repositioningEnabled = (CBool) CR2WTypeManager.Create("Bool", "repositioningEnabled", cr2w, this);
				}
				return _repositioningEnabled;
			}
			set
			{
				if (_repositioningEnabled == value)
				{
					return;
				}
				_repositioningEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("obstructionFadeTime")] 
		public CFloat ObstructionFadeTime
		{
			get
			{
				if (_obstructionFadeTime == null)
				{
					_obstructionFadeTime = (CFloat) CR2WTypeManager.Create("Float", "obstructionFadeTime", cr2w, this);
				}
				return _obstructionFadeTime;
			}
			set
			{
				if (_obstructionFadeTime == value)
				{
					return;
				}
				_obstructionFadeTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("enableOutdoorness")] 
		public CBool EnableOutdoorness
		{
			get
			{
				if (_enableOutdoorness == null)
				{
					_enableOutdoorness = (CBool) CR2WTypeManager.Create("Bool", "enableOutdoorness", cr2w, this);
				}
				return _enableOutdoorness;
			}
			set
			{
				if (_enableOutdoorness == value)
				{
					return;
				}
				_enableOutdoorness = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("postDopplerFactor")] 
		public CBool PostDopplerFactor
		{
			get
			{
				if (_postDopplerFactor == null)
				{
					_postDopplerFactor = (CBool) CR2WTypeManager.Create("Bool", "postDopplerFactor", cr2w, this);
				}
				return _postDopplerFactor;
			}
			set
			{
				if (_postDopplerFactor == value)
				{
					return;
				}
				_postDopplerFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("dopplerParameter")] 
		public CName DopplerParameter
		{
			get
			{
				if (_dopplerParameter == null)
				{
					_dopplerParameter = (CName) CR2WTypeManager.Create("CName", "dopplerParameter", cr2w, this);
				}
				return _dopplerParameter;
			}
			set
			{
				if (_dopplerParameter == value)
				{
					return;
				}
				_dopplerParameter = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("ignoreOcclusionRadius")] 
		public CFloat IgnoreOcclusionRadius
		{
			get
			{
				if (_ignoreOcclusionRadius == null)
				{
					_ignoreOcclusionRadius = (CFloat) CR2WTypeManager.Create("Float", "ignoreOcclusionRadius", cr2w, this);
				}
				return _ignoreOcclusionRadius;
			}
			set
			{
				if (_ignoreOcclusionRadius == value)
				{
					return;
				}
				_ignoreOcclusionRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("elevateSource")] 
		public CBool ElevateSource
		{
			get
			{
				if (_elevateSource == null)
				{
					_elevateSource = (CBool) CR2WTypeManager.Create("Bool", "elevateSource", cr2w, this);
				}
				return _elevateSource;
			}
			set
			{
				if (_elevateSource == value)
				{
					return;
				}
				_elevateSource = value;
				PropertySet(this);
			}
		}

		public audioAcousticsEmitterMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
