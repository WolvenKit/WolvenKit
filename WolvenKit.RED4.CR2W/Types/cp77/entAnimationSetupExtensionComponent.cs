using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimationSetupExtensionComponent : entIComponent
	{
		private animAnimSetup _animations;
		private CHandle<entAnimationControlBinding> _controlBinding;

		[Ordinal(3)] 
		[RED("animations")] 
		public animAnimSetup Animations
		{
			get
			{
				if (_animations == null)
				{
					_animations = (animAnimSetup) CR2WTypeManager.Create("animAnimSetup", "animations", cr2w, this);
				}
				return _animations;
			}
			set
			{
				if (_animations == value)
				{
					return;
				}
				_animations = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("controlBinding")] 
		public CHandle<entAnimationControlBinding> ControlBinding
		{
			get
			{
				if (_controlBinding == null)
				{
					_controlBinding = (CHandle<entAnimationControlBinding>) CR2WTypeManager.Create("handle:entAnimationControlBinding", "controlBinding", cr2w, this);
				}
				return _controlBinding;
			}
			set
			{
				if (_controlBinding == value)
				{
					return;
				}
				_controlBinding = value;
				PropertySet(this);
			}
		}

		public entAnimationSetupExtensionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
