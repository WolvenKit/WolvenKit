using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AimDownSightController : BasicAnimationController
	{
		[Ordinal(6)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
