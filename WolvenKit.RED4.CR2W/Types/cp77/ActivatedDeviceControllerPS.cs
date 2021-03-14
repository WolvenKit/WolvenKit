using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceControllerPS : ScriptableDeviceComponentPS
	{
		private ActivatedDeviceAnimSetup _animationSetup;
		private ActivatedDeviceSetup _activatedDeviceSetup;
		private NodeRef _spiderbotInteractionLocationOverride;
		private CInt32 _industrialArmAnimationOverride;

		[Ordinal(103)] 
		[RED("animationSetup")] 
		public ActivatedDeviceAnimSetup AnimationSetup
		{
			get
			{
				if (_animationSetup == null)
				{
					_animationSetup = (ActivatedDeviceAnimSetup) CR2WTypeManager.Create("ActivatedDeviceAnimSetup", "animationSetup", cr2w, this);
				}
				return _animationSetup;
			}
			set
			{
				if (_animationSetup == value)
				{
					return;
				}
				_animationSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("activatedDeviceSetup")] 
		public ActivatedDeviceSetup ActivatedDeviceSetup
		{
			get
			{
				if (_activatedDeviceSetup == null)
				{
					_activatedDeviceSetup = (ActivatedDeviceSetup) CR2WTypeManager.Create("ActivatedDeviceSetup", "activatedDeviceSetup", cr2w, this);
				}
				return _activatedDeviceSetup;
			}
			set
			{
				if (_activatedDeviceSetup == value)
				{
					return;
				}
				_activatedDeviceSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("spiderbotInteractionLocationOverride")] 
		public NodeRef SpiderbotInteractionLocationOverride
		{
			get
			{
				if (_spiderbotInteractionLocationOverride == null)
				{
					_spiderbotInteractionLocationOverride = (NodeRef) CR2WTypeManager.Create("NodeRef", "spiderbotInteractionLocationOverride", cr2w, this);
				}
				return _spiderbotInteractionLocationOverride;
			}
			set
			{
				if (_spiderbotInteractionLocationOverride == value)
				{
					return;
				}
				_spiderbotInteractionLocationOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("industrialArmAnimationOverride")] 
		public CInt32 IndustrialArmAnimationOverride
		{
			get
			{
				if (_industrialArmAnimationOverride == null)
				{
					_industrialArmAnimationOverride = (CInt32) CR2WTypeManager.Create("Int32", "industrialArmAnimationOverride", cr2w, this);
				}
				return _industrialArmAnimationOverride;
			}
			set
			{
				if (_industrialArmAnimationOverride == value)
				{
					return;
				}
				_industrialArmAnimationOverride = value;
				PropertySet(this);
			}
		}

		public ActivatedDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
