using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BackDoorDeviceBlackboardDef : MasterDeviceBaseBlackboardDef
	{
		private gamebbScriptID_Bool _isInDefaultState;
		private gamebbScriptID_Int32 _shutdownModule;
		private gamebbScriptID_Int32 _bootModule;

		[Ordinal(8)] 
		[RED("isInDefaultState")] 
		public gamebbScriptID_Bool IsInDefaultState
		{
			get => GetProperty(ref _isInDefaultState);
			set => SetProperty(ref _isInDefaultState, value);
		}

		[Ordinal(9)] 
		[RED("shutdownModule")] 
		public gamebbScriptID_Int32 ShutdownModule
		{
			get => GetProperty(ref _shutdownModule);
			set => SetProperty(ref _shutdownModule, value);
		}

		[Ordinal(10)] 
		[RED("bootModule")] 
		public gamebbScriptID_Int32 BootModule
		{
			get => GetProperty(ref _bootModule);
			set => SetProperty(ref _bootModule, value);
		}

		public BackDoorDeviceBlackboardDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
