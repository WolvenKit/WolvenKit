using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDevice_ConditionType : questIObjectConditionType
	{
		private NodeRef _objectRef;
		private CName _deviceControllerClass;
		private CName _deviceConditionFunction;
		private CArray<questDevice_ConditionFunctionParameter> _functionParameters;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("deviceControllerClass")] 
		public CName DeviceControllerClass
		{
			get => GetProperty(ref _deviceControllerClass);
			set => SetProperty(ref _deviceControllerClass, value);
		}

		[Ordinal(2)] 
		[RED("deviceConditionFunction")] 
		public CName DeviceConditionFunction
		{
			get => GetProperty(ref _deviceConditionFunction);
			set => SetProperty(ref _deviceConditionFunction, value);
		}

		[Ordinal(3)] 
		[RED("functionParameters")] 
		public CArray<questDevice_ConditionFunctionParameter> FunctionParameters
		{
			get => GetProperty(ref _functionParameters);
			set => SetProperty(ref _functionParameters, value);
		}

		public questDevice_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
