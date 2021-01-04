using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questDeviceManager_NodeTypeParams : ISerializable
	{
		[Ordinal(0)]  [RED("actionProperties")] public CArray<questDeviceManager_ActionProperty> ActionProperties { get; set; }
		[Ordinal(1)]  [RED("deviceAction")] public CName DeviceAction { get; set; }
		[Ordinal(2)]  [RED("deviceControllerClass")] public CName DeviceControllerClass { get; set; }
		[Ordinal(3)]  [RED("entityRef")] public gameEntityReference EntityRef { get; set; }
		[Ordinal(4)]  [RED("objectRef")] public NodeRef ObjectRef { get; set; }
		[Ordinal(5)]  [RED("slotName")] public CName SlotName { get; set; }

		public questDeviceManager_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
