using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AimDownSightController : BasicAnimationController
	{
		private CBool _isAiming;

		[Ordinal(6)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get => GetProperty(ref _isAiming);
			set => SetProperty(ref _isAiming, value);
		}

		public AimDownSightController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
