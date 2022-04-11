using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entRagdollNotifyVelocityTresholdEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("velocity")] 
		public Vector4 Velocity
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public entRagdollNotifyVelocityTresholdEvent()
		{
			Velocity = new() { W = 1.000000F };
		}
	}
}
