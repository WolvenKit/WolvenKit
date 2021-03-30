using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerBBListeners : CVariable
	{
		private CUInt32 _kerenzikov;
		private CUInt32 _restrictedScene;
		private CUInt32 _dead;
		private CUInt32 _takedown;
		private CUInt32 _deviceTakeover;
		private CUInt32 _braindanceFPP;
		private CUInt32 _braindanceActive;
		private CUInt32 _veryHardLanding;

		[Ordinal(0)] 
		[RED("kerenzikov")] 
		public CUInt32 Kerenzikov
		{
			get => GetProperty(ref _kerenzikov);
			set => SetProperty(ref _kerenzikov, value);
		}

		[Ordinal(1)] 
		[RED("restrictedScene")] 
		public CUInt32 RestrictedScene
		{
			get => GetProperty(ref _restrictedScene);
			set => SetProperty(ref _restrictedScene, value);
		}

		[Ordinal(2)] 
		[RED("dead")] 
		public CUInt32 Dead
		{
			get => GetProperty(ref _dead);
			set => SetProperty(ref _dead, value);
		}

		[Ordinal(3)] 
		[RED("takedown")] 
		public CUInt32 Takedown
		{
			get => GetProperty(ref _takedown);
			set => SetProperty(ref _takedown, value);
		}

		[Ordinal(4)] 
		[RED("deviceTakeover")] 
		public CUInt32 DeviceTakeover
		{
			get => GetProperty(ref _deviceTakeover);
			set => SetProperty(ref _deviceTakeover, value);
		}

		[Ordinal(5)] 
		[RED("braindanceFPP")] 
		public CUInt32 BraindanceFPP
		{
			get => GetProperty(ref _braindanceFPP);
			set => SetProperty(ref _braindanceFPP, value);
		}

		[Ordinal(6)] 
		[RED("braindanceActive")] 
		public CUInt32 BraindanceActive
		{
			get => GetProperty(ref _braindanceActive);
			set => SetProperty(ref _braindanceActive, value);
		}

		[Ordinal(7)] 
		[RED("veryHardLanding")] 
		public CUInt32 VeryHardLanding
		{
			get => GetProperty(ref _veryHardLanding);
			set => SetProperty(ref _veryHardLanding, value);
		}

		public PlayerVisionModeControllerBBListeners(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
