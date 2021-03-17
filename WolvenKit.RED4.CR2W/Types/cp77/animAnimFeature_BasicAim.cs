using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_BasicAim : animAnimFeature
	{
		private CInt32 _aimState;
		private CInt32 _zoomState;

		[Ordinal(0)] 
		[RED("aimState")] 
		public CInt32 AimState
		{
			get => GetProperty(ref _aimState);
			set => SetProperty(ref _aimState, value);
		}

		[Ordinal(1)] 
		[RED("zoomState")] 
		public CInt32 ZoomState
		{
			get => GetProperty(ref _zoomState);
			set => SetProperty(ref _zoomState, value);
		}

		public animAnimFeature_BasicAim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
