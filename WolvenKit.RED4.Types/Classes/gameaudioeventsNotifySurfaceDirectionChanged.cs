using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioeventsNotifySurfaceDirectionChanged : redEvent
	{
		private CEnum<gameaudioeventsSurfaceDirection> _surfaceDirection;

		[Ordinal(0)] 
		[RED("surfaceDirection")] 
		public CEnum<gameaudioeventsSurfaceDirection> SurfaceDirection
		{
			get => GetProperty(ref _surfaceDirection);
			set => SetProperty(ref _surfaceDirection, value);
		}
	}
}
