using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questEventManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CBool _isObjectPlayer;
		private gameEntityReference _objectRef;
		private CString _managerName;
		private CHandle<IScriptable> _event;
		private CName _pSClassName;
		private CName _componentName;

		[Ordinal(2)] 
		[RED("isObjectPlayer")] 
		public CBool IsObjectPlayer
		{
			get => GetProperty(ref _isObjectPlayer);
			set => SetProperty(ref _isObjectPlayer, value);
		}

		[Ordinal(3)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(4)] 
		[RED("managerName")] 
		public CString ManagerName
		{
			get => GetProperty(ref _managerName);
			set => SetProperty(ref _managerName, value);
		}

		[Ordinal(5)] 
		[RED("event")] 
		public CHandle<IScriptable> Event
		{
			get => GetProperty(ref _event);
			set => SetProperty(ref _event, value);
		}

		[Ordinal(6)] 
		[RED("PSClassName")] 
		public CName PSClassName
		{
			get => GetProperty(ref _pSClassName);
			set => SetProperty(ref _pSClassName, value);
		}

		[Ordinal(7)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}
	}
}
