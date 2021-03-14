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
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("deviceControllerClass")] 
		public CName DeviceControllerClass
		{
			get
			{
				if (_deviceControllerClass == null)
				{
					_deviceControllerClass = (CName) CR2WTypeManager.Create("CName", "deviceControllerClass", cr2w, this);
				}
				return _deviceControllerClass;
			}
			set
			{
				if (_deviceControllerClass == value)
				{
					return;
				}
				_deviceControllerClass = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("deviceConditionFunction")] 
		public CName DeviceConditionFunction
		{
			get
			{
				if (_deviceConditionFunction == null)
				{
					_deviceConditionFunction = (CName) CR2WTypeManager.Create("CName", "deviceConditionFunction", cr2w, this);
				}
				return _deviceConditionFunction;
			}
			set
			{
				if (_deviceConditionFunction == value)
				{
					return;
				}
				_deviceConditionFunction = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("functionParameters")] 
		public CArray<questDevice_ConditionFunctionParameter> FunctionParameters
		{
			get
			{
				if (_functionParameters == null)
				{
					_functionParameters = (CArray<questDevice_ConditionFunctionParameter>) CR2WTypeManager.Create("array:questDevice_ConditionFunctionParameter", "functionParameters", cr2w, this);
				}
				return _functionParameters;
			}
			set
			{
				if (_functionParameters == value)
				{
					return;
				}
				_functionParameters = value;
				PropertySet(this);
			}
		}

		public questDevice_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
