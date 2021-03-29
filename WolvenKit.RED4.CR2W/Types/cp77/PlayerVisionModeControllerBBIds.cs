using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerBBIds : CVariable
	{
		private CHandle<gamebbScriptDefinition> _kerenzikov;
		private CHandle<gamebbScriptDefinition> _restrictedScene;
		private CHandle<gamebbScriptDefinition> _dead;
		private CHandle<gamebbScriptDefinition> _takedown;
		private CHandle<gamebbScriptDefinition> _deviceTakeover;
		private CHandle<gamebbScriptDefinition> _braindanceFPP;
		private CHandle<gamebbScriptDefinition> _braindanceActive;
		private CHandle<gamebbScriptDefinition> _veryHardLanding;

		[Ordinal(0)] 
		[RED("kerenzikov")] 
		public CHandle<gamebbScriptDefinition> Kerenzikov
		{
			get => GetProperty(ref _kerenzikov);
			set => SetProperty(ref _kerenzikov, value);
		}

		[Ordinal(1)] 
		[RED("restrictedScene")] 
		public CHandle<gamebbScriptDefinition> RestrictedScene
		{
			get => GetProperty(ref _restrictedScene);
			set => SetProperty(ref _restrictedScene, value);
		}

		[Ordinal(2)] 
		[RED("dead")] 
		public CHandle<gamebbScriptDefinition> Dead
		{
			get => GetProperty(ref _dead);
			set => SetProperty(ref _dead, value);
		}

		[Ordinal(3)] 
		[RED("takedown")] 
		public CHandle<gamebbScriptDefinition> Takedown
		{
			get => GetProperty(ref _takedown);
			set => SetProperty(ref _takedown, value);
		}

		[Ordinal(4)] 
		[RED("deviceTakeover")] 
		public CHandle<gamebbScriptDefinition> DeviceTakeover
		{
			get => GetProperty(ref _deviceTakeover);
			set => SetProperty(ref _deviceTakeover, value);
		}

		[Ordinal(5)] 
		[RED("braindanceFPP")] 
		public CHandle<gamebbScriptDefinition> BraindanceFPP
		{
			get => GetProperty(ref _braindanceFPP);
			set => SetProperty(ref _braindanceFPP, value);
		}

		[Ordinal(6)] 
		[RED("braindanceActive")] 
		public CHandle<gamebbScriptDefinition> BraindanceActive
		{
			get => GetProperty(ref _braindanceActive);
			set => SetProperty(ref _braindanceActive, value);
		}

		[Ordinal(7)] 
		[RED("veryHardLanding")] 
		public CHandle<gamebbScriptDefinition> VeryHardLanding
		{
			get => GetProperty(ref _veryHardLanding);
			set => SetProperty(ref _veryHardLanding, value);
		}

		public PlayerVisionModeControllerBBIds(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
