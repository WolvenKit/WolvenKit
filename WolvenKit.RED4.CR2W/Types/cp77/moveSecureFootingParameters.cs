using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class moveSecureFootingParameters : CVariable
	{
		private CName _unsecureCollisionFilterName;
		private CFloat _maxVerticalDistanceForCentreRaycast;
		private CFloat _maxAngularDistanceForOtherRaycasts;
		private CUInt32 _standingMinNumberOfRaycasts;
		private CFloat _standingMinCollisionHorizontalDistance;
		private CUInt32 _fallingMinNumberOfRaycasts;
		private CFloat _fallingMinCollisionHorizontalDistance;
		private CFloat _maxStaticGroundFactor;
		private CBool _needsCentreRaycast;
		private CFloat _minVelocityForFalling;
		private CName _slopeCurveName;

		[Ordinal(0)] 
		[RED("unsecureCollisionFilterName")] 
		public CName UnsecureCollisionFilterName
		{
			get
			{
				if (_unsecureCollisionFilterName == null)
				{
					_unsecureCollisionFilterName = (CName) CR2WTypeManager.Create("CName", "unsecureCollisionFilterName", cr2w, this);
				}
				return _unsecureCollisionFilterName;
			}
			set
			{
				if (_unsecureCollisionFilterName == value)
				{
					return;
				}
				_unsecureCollisionFilterName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("maxVerticalDistanceForCentreRaycast")] 
		public CFloat MaxVerticalDistanceForCentreRaycast
		{
			get
			{
				if (_maxVerticalDistanceForCentreRaycast == null)
				{
					_maxVerticalDistanceForCentreRaycast = (CFloat) CR2WTypeManager.Create("Float", "maxVerticalDistanceForCentreRaycast", cr2w, this);
				}
				return _maxVerticalDistanceForCentreRaycast;
			}
			set
			{
				if (_maxVerticalDistanceForCentreRaycast == value)
				{
					return;
				}
				_maxVerticalDistanceForCentreRaycast = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("maxAngularDistanceForOtherRaycasts")] 
		public CFloat MaxAngularDistanceForOtherRaycasts
		{
			get
			{
				if (_maxAngularDistanceForOtherRaycasts == null)
				{
					_maxAngularDistanceForOtherRaycasts = (CFloat) CR2WTypeManager.Create("Float", "maxAngularDistanceForOtherRaycasts", cr2w, this);
				}
				return _maxAngularDistanceForOtherRaycasts;
			}
			set
			{
				if (_maxAngularDistanceForOtherRaycasts == value)
				{
					return;
				}
				_maxAngularDistanceForOtherRaycasts = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("standingMinNumberOfRaycasts")] 
		public CUInt32 StandingMinNumberOfRaycasts
		{
			get
			{
				if (_standingMinNumberOfRaycasts == null)
				{
					_standingMinNumberOfRaycasts = (CUInt32) CR2WTypeManager.Create("Uint32", "standingMinNumberOfRaycasts", cr2w, this);
				}
				return _standingMinNumberOfRaycasts;
			}
			set
			{
				if (_standingMinNumberOfRaycasts == value)
				{
					return;
				}
				_standingMinNumberOfRaycasts = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("standingMinCollisionHorizontalDistance")] 
		public CFloat StandingMinCollisionHorizontalDistance
		{
			get
			{
				if (_standingMinCollisionHorizontalDistance == null)
				{
					_standingMinCollisionHorizontalDistance = (CFloat) CR2WTypeManager.Create("Float", "standingMinCollisionHorizontalDistance", cr2w, this);
				}
				return _standingMinCollisionHorizontalDistance;
			}
			set
			{
				if (_standingMinCollisionHorizontalDistance == value)
				{
					return;
				}
				_standingMinCollisionHorizontalDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("fallingMinNumberOfRaycasts")] 
		public CUInt32 FallingMinNumberOfRaycasts
		{
			get
			{
				if (_fallingMinNumberOfRaycasts == null)
				{
					_fallingMinNumberOfRaycasts = (CUInt32) CR2WTypeManager.Create("Uint32", "fallingMinNumberOfRaycasts", cr2w, this);
				}
				return _fallingMinNumberOfRaycasts;
			}
			set
			{
				if (_fallingMinNumberOfRaycasts == value)
				{
					return;
				}
				_fallingMinNumberOfRaycasts = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("fallingMinCollisionHorizontalDistance")] 
		public CFloat FallingMinCollisionHorizontalDistance
		{
			get
			{
				if (_fallingMinCollisionHorizontalDistance == null)
				{
					_fallingMinCollisionHorizontalDistance = (CFloat) CR2WTypeManager.Create("Float", "fallingMinCollisionHorizontalDistance", cr2w, this);
				}
				return _fallingMinCollisionHorizontalDistance;
			}
			set
			{
				if (_fallingMinCollisionHorizontalDistance == value)
				{
					return;
				}
				_fallingMinCollisionHorizontalDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("maxStaticGroundFactor")] 
		public CFloat MaxStaticGroundFactor
		{
			get
			{
				if (_maxStaticGroundFactor == null)
				{
					_maxStaticGroundFactor = (CFloat) CR2WTypeManager.Create("Float", "maxStaticGroundFactor", cr2w, this);
				}
				return _maxStaticGroundFactor;
			}
			set
			{
				if (_maxStaticGroundFactor == value)
				{
					return;
				}
				_maxStaticGroundFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("needsCentreRaycast")] 
		public CBool NeedsCentreRaycast
		{
			get
			{
				if (_needsCentreRaycast == null)
				{
					_needsCentreRaycast = (CBool) CR2WTypeManager.Create("Bool", "needsCentreRaycast", cr2w, this);
				}
				return _needsCentreRaycast;
			}
			set
			{
				if (_needsCentreRaycast == value)
				{
					return;
				}
				_needsCentreRaycast = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("minVelocityForFalling")] 
		public CFloat MinVelocityForFalling
		{
			get
			{
				if (_minVelocityForFalling == null)
				{
					_minVelocityForFalling = (CFloat) CR2WTypeManager.Create("Float", "minVelocityForFalling", cr2w, this);
				}
				return _minVelocityForFalling;
			}
			set
			{
				if (_minVelocityForFalling == value)
				{
					return;
				}
				_minVelocityForFalling = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("slopeCurveName")] 
		public CName SlopeCurveName
		{
			get
			{
				if (_slopeCurveName == null)
				{
					_slopeCurveName = (CName) CR2WTypeManager.Create("CName", "slopeCurveName", cr2w, this);
				}
				return _slopeCurveName;
			}
			set
			{
				if (_slopeCurveName == value)
				{
					return;
				}
				_slopeCurveName = value;
				PropertySet(this);
			}
		}

		public moveSecureFootingParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
