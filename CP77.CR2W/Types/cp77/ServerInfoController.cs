using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ServerInfoController : inkListItemController
	{
		[Ordinal(0)]  [RED("address")] public wCHandle<inkTextWidget> Address { get; set; }
		[Ordinal(1)]  [RED("addressPath")] public CName AddressPath { get; set; }
		[Ordinal(2)]  [RED("background")] public wCHandle<inkImageWidget> Background { get; set; }
		[Ordinal(3)]  [RED("c_initialColor")] public HDRColor C_initialColor { get; set; }
		[Ordinal(4)]  [RED("c_markColor")] public HDRColor C_markColor { get; set; }
		[Ordinal(5)]  [RED("c_selectionColor")] public CColor C_selectionColor { get; set; }
		[Ordinal(6)]  [RED("hostname")] public wCHandle<inkTextWidget> Hostname { get; set; }
		[Ordinal(7)]  [RED("hostnamePath")] public CName HostnamePath { get; set; }
		[Ordinal(8)]  [RED("kind")] public wCHandle<inkTextWidget> Kind { get; set; }
		[Ordinal(9)]  [RED("kindPath")] public CName KindPath { get; set; }
		[Ordinal(10)]  [RED("marked")] public CBool Marked { get; set; }
		[Ordinal(11)]  [RED("number")] public wCHandle<inkTextWidget> Number { get; set; }
		[Ordinal(12)]  [RED("numberPath")] public CName NumberPath { get; set; }
		[Ordinal(13)]  [RED("settingsListCtrl")] public wCHandle<inkListController> SettingsListCtrl { get; set; }
		[Ordinal(14)]  [RED("worldDescription")] public wCHandle<inkTextWidget> WorldDescription { get; set; }
		[Ordinal(15)]  [RED("worldDescriptionPath")] public CName WorldDescriptionPath { get; set; }

		public ServerInfoController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
