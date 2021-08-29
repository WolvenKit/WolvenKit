using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineeventImpulse : gamestateMachineeventBaseEvent
	{
		private Vector4 _impulse;

		[Ordinal(1)] 
		[RED("impulse")] 
		public Vector4 Impulse
		{
			get => GetProperty(ref _impulse);
			set => SetProperty(ref _impulse, value);
		}
	}
}
