using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorRegisterBlackBoardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _vendors;

		[Ordinal(0)] 
		[RED("vendors")] 
		public gamebbScriptID_Variant Vendors
		{
			get
			{
				if (_vendors == null)
				{
					_vendors = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "vendors", cr2w, this);
				}
				return _vendors;
			}
			set
			{
				if (_vendors == value)
				{
					return;
				}
				_vendors = value;
				PropertySet(this);
			}
		}

		public VendorRegisterBlackBoardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
