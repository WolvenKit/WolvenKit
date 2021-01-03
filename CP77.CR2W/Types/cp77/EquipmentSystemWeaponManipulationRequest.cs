using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EquipmentSystemWeaponManipulationRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("equipAnimType")] public CEnum<gameEquipAnimationType> EquipAnimType { get; set; }
		[Ordinal(1)]  [RED("removeItemFromEquipSlot")] public CBool RemoveItemFromEquipSlot { get; set; }
		[Ordinal(2)]  [RED("requestType")] public CEnum<EquipmentManipulationAction> RequestType { get; set; }

		public EquipmentSystemWeaponManipulationRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
