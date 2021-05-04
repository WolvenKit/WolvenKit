using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsNotifySurfaceDirectionChanged : redEvent
	{
		private CEnum<gameaudioeventsSurfaceDirection> _surfaceDirection;

		[Ordinal(0)] 
		[RED("surfaceDirection")] 
		public CEnum<gameaudioeventsSurfaceDirection> SurfaceDirection
		{
			get => GetProperty(ref _surfaceDirection);
			set => SetProperty(ref _surfaceDirection, value);
		}

		public gameaudioeventsNotifySurfaceDirectionChanged(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
