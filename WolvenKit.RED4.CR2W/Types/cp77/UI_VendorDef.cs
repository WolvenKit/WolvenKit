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
			get => GetProperty(ref _vendorData);
			set => SetProperty(ref _vendorData, value);
		}

		public UI_VendorDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
