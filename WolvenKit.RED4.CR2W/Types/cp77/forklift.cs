using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class forklift : InteractiveDevice
	{
		private CHandle<AnimFeature_ForkliftDevice> _animFeature;
		private CHandle<entAnimationControllerComponent> _animationController;
		private CBool _isPlayerUnder;
		private CHandle<entPhysicalMeshComponent> _cargoBox;

		[Ordinal(93)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_ForkliftDevice> AnimFeature
		{
			get
			{
				if (_animFeature == null)
				{
					_animFeature = (CHandle<AnimFeature_ForkliftDevice>) CR2WTypeManager.Create("handle:AnimFeature_ForkliftDevice", "animFeature", cr2w, this);
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
		[RED("isPlayerUnder")] 
		public CBool IsPlayerUnder
		{
			get
			{
				if (_isPlayerUnder == null)
				{
					_isPlayerUnder = (CBool) CR2WTypeManager.Create("Bool", "isPlayerUnder", cr2w, this);
				}
				return _isPlayerUnder;
			}
			set
			{
				if (_isPlayerUnder == value)
				{
					return;
				}
				_isPlayerUnder = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("cargoBox")] 
		public CHandle<entPhysicalMeshComponent> CargoBox
		{
			get
			{
				if (_cargoBox == null)
				{
					_cargoBox = (CHandle<entPhysicalMeshComponent>) CR2WTypeManager.Create("handle:entPhysicalMeshComponent", "cargoBox", cr2w, this);
				}
				return _cargoBox;
			}
			set
			{
				if (_cargoBox == value)
				{
					return;
				}
				_cargoBox = value;
				PropertySet(this);
			}
		}

		public forklift(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
