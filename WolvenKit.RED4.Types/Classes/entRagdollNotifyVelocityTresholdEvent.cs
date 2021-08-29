using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entRagdollNotifyVelocityTresholdEvent : redEvent
	{
		private Vector4 _velocity;

		[Ordinal(0)] 
		[RED("velocity")] 
		public Vector4 Velocity
		{
			get => GetProperty(ref _velocity);
			set => SetProperty(ref _velocity, value);
		}
	}
}
