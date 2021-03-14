using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RoadBlock : InteractiveDevice
	{
		private CFloat _openingSpeed;
		private CHandle<entAnimationControllerComponent> _animationController;
		private CHandle<AIOffMeshConnectionComponent> _offMeshConnection;
		private CHandle<AnimFeature_RoadBlock> _animFeature;
		private CEnum<EAnimationType> _animationType;
		private CBool _forceEnableLink;

		[Ordinal(93)] 
		[RED("openingSpeed")] 
		public CFloat OpeningSpeed
		{
			get
			{
				if (_openingSpeed == null)
				{
					_openingSpeed = (CFloat) CR2WTypeManager.Create("Float", "openingSpeed", cr2w, this);
				}
				return _openingSpeed;
			}
			set
			{
				if (_openingSpeed == value)
				{
					return;
				}
				_openingSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get
			{
				if (_animationController == null)
				{
					_animationController = (CHandle<entAnimationControllerComponent>) CR2WTypeManager.Create("handle:entAnimationControllerComponent", "animationController", cr2w, this);
				}
				return _animationController;
			}
			set
			{
				if (_animationController == value)
				{
					return;
				}
				_animationController = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("offMeshConnection")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnection
		{
			get
			{
				if (_offMeshConnection == null)
				{
					_offMeshConnection = (CHandle<AIOffMeshConnectionComponent>) CR2WTypeManager.Create("handle:AIOffMeshConnectionComponent", "offMeshConnection", cr2w, this);
				}
				return _offMeshConnection;
			}
			set
			{
				if (_offMeshConnection == value)
				{
					return;
				}
				_offMeshConnection = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_RoadBlock> AnimFeature
		{
			get
			{
				if (_animFeature == null)
				{
					_animFeature = (CHandle<AnimFeature_RoadBlock>) CR2WTypeManager.Create("handle:AnimFeature_RoadBlock", "animFeature", cr2w, this);
				}
				return _animFeature;
			}
			set
			{
				if (_animFeature == value)
				{
					return;
				}
				_animFeature = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get
			{
				if (_animationType == null)
				{
					_animationType = (CEnum<EAnimationType>) CR2WTypeManager.Create("EAnimationType", "animationType", cr2w, this);
				}
				return _animationType;
			}
			set
			{
				if (_animationType == value)
				{
					return;
				}
				_animationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("forceEnableLink")] 
		public CBool ForceEnableLink
		{
			get
			{
				if (_forceEnableLink == null)
				{
					_forceEnableLink = (CBool) CR2WTypeManager.Create("Bool", "forceEnableLink", cr2w, this);
				}
				return _forceEnableLink;
			}
			set
			{
				if (_forceEnableLink == value)
				{
					return;
				}
				_forceEnableLink = value;
				PropertySet(this);
			}
		}

		public RoadBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
