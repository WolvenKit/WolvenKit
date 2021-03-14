using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_VendorDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _vendorData;

		[Ordinal(0)] 
		[RED("VendorData")] 
		public gamebbScriptID_Variant VendorData
		{
			get
			{
				if (_vendorData == null)
				{
					_vendorData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "VendorData", cr2w, this);
				}
				return _vendorData;
			}
			set
			{
				if (_vendorData == value)
				{
					return;
				}
				_vendorData = value;
				PropertySet(this);
			}
		}

		public UI_VendorDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
