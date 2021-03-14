using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceIndustrialArm : ActivatedDeviceTrap
	{
		private CEnum<EIndustrialArmAnimations> _loopAnimation;

		[Ordinal(95)] 
		[RED("loopAnimation")] 
		public CEnum<EIndustrialArmAnimations> LoopAnimation
		{
			get
			{
				if (_loopAnimation == null)
				{
					_loopAnimation = (CEnum<EIndustrialArmAnimations>) CR2WTypeManager.Create("EIndustrialArmAnimations", "loopAnimation", cr2w, this);
				}
				return _loopAnimation;
			}
			set
			{
				if (_loopAnimation == value)
				{
					return;
				}
				_loopAnimation = value;
				PropertySet(this);
			}
		}

		public ActivatedDeviceIndustrialArm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
