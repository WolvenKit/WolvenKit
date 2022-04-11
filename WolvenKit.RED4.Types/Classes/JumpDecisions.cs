using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class JumpDecisions : LocomotionAirDecisions
	{
		[Ordinal(3)] 
		[RED("jumpPressed")] 
		public CBool JumpPressed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
