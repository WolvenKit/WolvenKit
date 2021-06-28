using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDeviceManager_NodeTypeParams : ISerializable
	{
		private NodeRef _objectRef;
		private CName _slotName;
		private gameEntityReference _entityRef;
		private CName _deviceControllerClass;
		private CName _deviceAction;
		private CArray<questDeviceManager_ActionProperty> _actionProperties;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(2)] 
		[RED("entityRef")] 
		public gameEntityReference EntityRef
		{
			get => GetProperty(ref _entityRef);
			set => SetProperty(ref _entityRef, value);
		}

		[Ordinal(3)] 
		[RED("deviceControllerClass")] 
		public CName DeviceControllerClass
		{
			get => GetProperty(ref _deviceControllerClass);
			set => SetProperty(ref _deviceControllerClass, value);
		}

		[Ordinal(4)] 
		[RED("deviceAction")] 
		public CName DeviceAction
		{
			get => GetProperty(ref _deviceAction);
			set => SetProperty(ref _deviceAction, value);
		}

		[Ordinal(5)] 
		[RED("actionProperties")] 
		public CArray<questDeviceManager_ActionProperty> ActionProperties
		{
			get => GetProperty(ref _actionProperties);
			set => SetProperty(ref _actionProperties, value);
		}

		public questDeviceManager_NodeTypeParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
