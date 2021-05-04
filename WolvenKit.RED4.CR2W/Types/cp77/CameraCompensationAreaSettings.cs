using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraCompensationAreaSettings : CVariable
	{
		private CBool _automated;
		private CUInt32 _iSO;
		private CFloat _shutterTime;
		private CFloat _fStop;

		[Ordinal(0)] 
		[RED("automated")] 
		public CBool Automated
		{
			get => GetProperty(ref _automated);
			set => SetProperty(ref _automated, value);
		}

		[Ordinal(1)] 
		[RED("ISO")] 
		public CUInt32 ISO
		{
			get => GetProperty(ref _iSO);
			set => SetProperty(ref _iSO, value);
		}

		[Ordinal(2)] 
		[RED("shutterTime")] 
		public CFloat ShutterTime
		{
			get => GetProperty(ref _shutterTime);
			set => SetProperty(ref _shutterTime, value);
		}

		[Ordinal(3)] 
		[RED("fStop")] 
		public CFloat FStop
		{
			get => GetProperty(ref _fStop);
			set => SetProperty(ref _fStop, value);
		}

		public CameraCompensationAreaSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
