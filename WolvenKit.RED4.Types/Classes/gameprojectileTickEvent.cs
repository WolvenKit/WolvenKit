using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileTickEvent : redEvent
	{
		private CFloat _deltaTime;
		private Vector4 _position;

		[Ordinal(0)] 
		[RED("deltaTime")] 
		public CFloat DeltaTime
		{
			get => GetProperty(ref _deltaTime);
			set => SetProperty(ref _deltaTime, value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}
	}
}
