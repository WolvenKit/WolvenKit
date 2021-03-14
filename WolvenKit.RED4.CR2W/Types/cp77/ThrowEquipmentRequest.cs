using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ThrowEquipmentRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("itemObject")] public wCHandle<gameItemObject> ItemObject { get; set; }

		public ThrowEquipmentRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
