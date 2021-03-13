using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ServerInfoController : inkListItemController
	{
		[Ordinal(16)] [RED("settingsListCtrl")] public wCHandle<inkListController> SettingsListCtrl { get; set; }
		[Ordinal(17)] [RED("number")] public wCHandle<inkTextWidget> Number { get; set; }
		[Ordinal(18)] [RED("numberPath")] public CName NumberPath { get; set; }
		[Ordinal(19)] [RED("kind")] public wCHandle<inkTextWidget> Kind { get; set; }
		[Ordinal(20)] [RED("kindPath")] public CName KindPath { get; set; }
		[Ordinal(21)] [RED("hostname")] public wCHandle<inkTextWidget> Hostname { get; set; }
		[Ordinal(22)] [RED("hostnamePath")] public CName HostnamePath { get; set; }
		[Ordinal(23)] [RED("address")] public wCHandle<inkTextWidget> Address { get; set; }
		[Ordinal(24)] [RED("addressPath")] public CName AddressPath { get; set; }
		[Ordinal(25)] [RED("worldDescription")] public wCHandle<inkTextWidget> WorldDescription { get; set; }
		[Ordinal(26)] [RED("worldDescriptionPath")] public CName WorldDescriptionPath { get; set; }
		[Ordinal(27)] [RED("background")] public wCHandle<inkImageWidget> Background { get; set; }
		[Ordinal(28)] [RED("c_selectionColor")] public CColor C_selectionColor { get; set; }
		[Ordinal(29)] [RED("c_initialColor")] public HDRColor C_initialColor { get; set; }
		[Ordinal(30)] [RED("c_markColor")] public HDRColor C_markColor { get; set; }
		[Ordinal(31)] [RED("marked")] public CBool Marked { get; set; }

		public ServerInfoController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
