using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipmentSystemWeaponManipulationRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("requestType")] public CEnum<EquipmentManipulationAction> RequestType { get; set; }
		[Ordinal(2)] [RED("equipAnimType")] public CEnum<gameEquipAnimationType> EquipAnimType { get; set; }
		[Ordinal(3)] [RED("removeItemFromEquipSlot")] public CBool RemoveItemFromEquipSlot { get; set; }

		public EquipmentSystemWeaponManipulationRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
