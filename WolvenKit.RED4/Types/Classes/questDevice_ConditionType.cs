using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questDevice_ConditionType : questIObjectConditionType
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("deviceControllerClass")] 
		public CName DeviceControllerClass
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("deviceConditionFunction")] 
		public CName DeviceConditionFunction
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("functionParameters")] 
		public CArray<questDevice_ConditionFunctionParameter> FunctionParameters
		{
			get => GetPropertyValue<CArray<questDevice_ConditionFunctionParameter>>();
			set => SetPropertyValue<CArray<questDevice_ConditionFunctionParameter>>(value);
		}

		public questDevice_ConditionType()
		{
			FunctionParameters = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
