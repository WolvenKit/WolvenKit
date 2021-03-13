using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDeviceManager_NodeTypeParams : ISerializable
	{
		[Ordinal(0)] [RED("objectRef")] public NodeRef ObjectRef { get; set; }
		[Ordinal(1)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(2)] [RED("entityRef")] public gameEntityReference EntityRef { get; set; }
		[Ordinal(3)] [RED("deviceControllerClass")] public CName DeviceControllerClass { get; set; }
		[Ordinal(4)] [RED("deviceAction")] public CName DeviceAction { get; set; }
		[Ordinal(5)] [RED("actionProperties")] public CArray<questDeviceManager_ActionProperty> ActionProperties { get; set; }

		public questDeviceManager_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
