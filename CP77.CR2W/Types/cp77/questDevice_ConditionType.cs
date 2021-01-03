using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questDevice_ConditionType : questIObjectConditionType
	{
		[Ordinal(0)]  [RED("deviceConditionFunction")] public CName DeviceConditionFunction { get; set; }
		[Ordinal(1)]  [RED("deviceControllerClass")] public CName DeviceControllerClass { get; set; }
		[Ordinal(2)]  [RED("functionParameters")] public CArray<questDevice_ConditionFunctionParameter> FunctionParameters { get; set; }
		[Ordinal(3)]  [RED("objectRef")] public NodeRef ObjectRef { get; set; }

		public questDevice_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
