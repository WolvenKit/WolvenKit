using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameaudioeventsNotifySurfaceDirectionChanged : redEvent
	{
		[Ordinal(0)] 
		[RED("surfaceDirection")] 
		public CEnum<gameaudioeventsSurfaceDirection> SurfaceDirection
		{
			get => GetPropertyValue<CEnum<gameaudioeventsSurfaceDirection>>();
			set => SetPropertyValue<CEnum<gameaudioeventsSurfaceDirection>>(value);
		}

		public gameaudioeventsNotifySurfaceDirectionChanged()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
