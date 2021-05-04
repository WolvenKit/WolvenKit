using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IntercomBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_String _displayString;
		private gamebbScriptID_Bool _enableActions;
		private gamebbScriptID_Variant _status;

		[Ordinal(7)] 
		[RED("DisplayString")] 
		public gamebbScriptID_String DisplayString
		{
			get => GetProperty(ref _displayString);
			set => SetProperty(ref _displayString, value);
		}

		[Ordinal(8)] 
		[RED("EnableActions")] 
		public gamebbScriptID_Bool EnableActions
		{
			get => GetProperty(ref _enableActions);
			set => SetProperty(ref _enableActions, value);
		}

		[Ordinal(9)] 
		[RED("Status")] 
		public gamebbScriptID_Variant Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		public IntercomBlackboardDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
