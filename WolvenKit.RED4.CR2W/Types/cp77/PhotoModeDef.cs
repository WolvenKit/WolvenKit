using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhotoModeDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _isActive;
		private gamebbScriptID_Uint32 _playerHealthState;

		[Ordinal(0)] 
		[RED("IsActive")] 
		public gamebbScriptID_Bool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(1)] 
		[RED("PlayerHealthState")] 
		public gamebbScriptID_Uint32 PlayerHealthState
		{
			get => GetProperty(ref _playerHealthState);
			set => SetProperty(ref _playerHealthState, value);
		}

		public PhotoModeDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
