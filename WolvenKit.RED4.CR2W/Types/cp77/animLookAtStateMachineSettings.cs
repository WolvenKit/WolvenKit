using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtStateMachineSettings : CVariable
	{
		private CName _partName;
		private CName _partAlias;
		private CName _sphereAttachmentBone;
		private CFloat _sphereRadius;
		private CFloat _followingSpeedFactor;
		private curveData<CFloat> _followingSpeedByAngleCurve;
		private CName _enableFloatTrack;
		private CName _eyesOverrideFloatTrack;
		private CFloat _transitionSpeedMultiplier;
		private CFloat _blendWeightPowFactor;
		private CName _coneLimitReached;

		[Ordinal(0)] 
		[RED("partName")] 
		public CName PartName
		{
			get
			{
				if (_partName == null)
				{
					_partName = (CName) CR2WTypeManager.Create("CName", "partName", cr2w, this);
				}
				return _partName;
			}
			set
			{
				if (_partName == value)
				{
					return;
				}
				_partName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("partAlias")] 
		public CName PartAlias
		{
			get
			{
				if (_partAlias == null)
				{
					_partAlias = (CName) CR2WTypeManager.Create("CName", "partAlias", cr2w, this);
				}
				return _partAlias;
			}
			set
			{
				if (_partAlias == value)
				{
					return;
				}
				_partAlias = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("sphereAttachmentBone")] 
		public CName SphereAttachmentBone
		{
			get
			{
				if (_sphereAttachmentBone == null)
				{
					_sphereAttachmentBone = (CName) CR2WTypeManager.Create("CName", "sphereAttachmentBone", cr2w, this);
				}
				return _sphereAttachmentBone;
			}
			set
			{
				if (_sphereAttachmentBone == value)
				{
					return;
				}
				_sphereAttachmentBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("sphereRadius")] 
		public CFloat SphereRadius
		{
			get
			{
				if (_sphereRadius == null)
				{
					_sphereRadius = (CFloat) CR2WTypeManager.Create("Float", "sphereRadius", cr2w, this);
				}
				return _sphereRadius;
			}
			set
			{
				if (_sphereRadius == value)
				{
					return;
				}
				_sphereRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("followingSpeedFactor")] 
		public CFloat FollowingSpeedFactor
		{
			get
			{
				if (_followingSpeedFactor == null)
				{
					_followingSpeedFactor = (CFloat) CR2WTypeManager.Create("Float", "followingSpeedFactor", cr2w, this);
				}
				return _followingSpeedFactor;
			}
			set
			{
				if (_followingSpeedFactor == value)
				{
					return;
				}
				_followingSpeedFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("followingSpeedByAngleCurve")] 
		public curveData<CFloat> FollowingSpeedByAngleCurve
		{
			get
			{
				if (_followingSpeedByAngleCurve == null)
				{
					_followingSpeedByAngleCurve = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "followingSpeedByAngleCurve", cr2w, this);
				}
				return _followingSpeedByAngleCurve;
			}
			set
			{
				if (_followingSpeedByAngleCurve == value)
				{
					return;
				}
				_followingSpeedByAngleCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("enableFloatTrack")] 
		public CName EnableFloatTrack
		{
			get
			{
				if (_enableFloatTrack == null)
				{
					_enableFloatTrack = (CName) CR2WTypeManager.Create("CName", "enableFloatTrack", cr2w, this);
				}
				return _enableFloatTrack;
			}
			set
			{
				if (_enableFloatTrack == value)
				{
					return;
				}
				_enableFloatTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("eyesOverrideFloatTrack")] 
		public CName EyesOverrideFloatTrack
		{
			get
			{
				if (_eyesOverrideFloatTrack == null)
				{
					_eyesOverrideFloatTrack = (CName) CR2WTypeManager.Create("CName", "eyesOverrideFloatTrack", cr2w, this);
				}
				return _eyesOverrideFloatTrack;
			}
			set
			{
				if (_eyesOverrideFloatTrack == value)
				{
					return;
				}
				_eyesOverrideFloatTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("transitionSpeedMultiplier")] 
		public CFloat TransitionSpeedMultiplier
		{
			get
			{
				if (_transitionSpeedMultiplier == null)
				{
					_transitionSpeedMultiplier = (CFloat) CR2WTypeManager.Create("Float", "transitionSpeedMultiplier", cr2w, this);
				}
				return _transitionSpeedMultiplier;
			}
			set
			{
				if (_transitionSpeedMultiplier == value)
				{
					return;
				}
				_transitionSpeedMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("blendWeightPowFactor")] 
		public CFloat BlendWeightPowFactor
		{
			get
			{
				if (_blendWeightPowFactor == null)
				{
					_blendWeightPowFactor = (CFloat) CR2WTypeManager.Create("Float", "blendWeightPowFactor", cr2w, this);
				}
				return _blendWeightPowFactor;
			}
			set
			{
				if (_blendWeightPowFactor == value)
				{
					return;
				}
				_blendWeightPowFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("coneLimitReached")] 
		public CName ConeLimitReached
		{
			get
			{
				if (_coneLimitReached == null)
				{
					_coneLimitReached = (CName) CR2WTypeManager.Create("CName", "coneLimitReached", cr2w, this);
				}
				return _coneLimitReached;
			}
			set
			{
				if (_coneLimitReached == value)
				{
					return;
				}
				_coneLimitReached = value;
				PropertySet(this);
			}
		}

		public animLookAtStateMachineSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
