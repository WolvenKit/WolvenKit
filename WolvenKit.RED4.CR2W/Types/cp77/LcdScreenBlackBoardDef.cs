using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LcdScreenBlackBoardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Variant _messegeData;

		[Ordinal(7)] 
		[RED("MessegeData")] 
		public gamebbScriptID_Variant MessegeData
		{
			get => GetProperty(ref _messegeData);
			set => SetProperty(ref _messegeData, value);
		}

		public LcdScreenBlackBoardDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
