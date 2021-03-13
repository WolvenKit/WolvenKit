using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipmentManipulationRequest : IScriptable
	{
		[Ordinal(0)] [RED("requestType")] public CEnum<EquipmentManipulationRequestType> RequestType { get; set; }
		[Ordinal(1)] [RED("requestSlot")] public CEnum<EquipmentManipulationRequestSlot> RequestSlot { get; set; }
		[Ordinal(2)] [RED("equipAnim")] public CEnum<gameEquipAnimationType> EquipAnim { get; set; }

		public EquipmentManipulationRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
