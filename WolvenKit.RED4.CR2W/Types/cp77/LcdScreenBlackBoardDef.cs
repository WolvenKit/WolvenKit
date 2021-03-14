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
			get
			{
				if (_messegeData == null)
				{
					_messegeData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "MessegeData", cr2w, this);
				}
				return _messegeData;
			}
			set
			{
				if (_messegeData == value)
				{
					return;
				}
				_messegeData = value;
				PropertySet(this);
			}
		}

		public LcdScreenBlackBoardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
