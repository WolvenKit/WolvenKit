using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questEntityManagerManageBinkComponent_NodeTypeParams : RedBaseClass
	{
		private gameEntityReference _objectRef;
		private CString _videoPath;
		private CEnum<gameBinkVideoAction> _action;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("videoPath")] 
		public CString VideoPath
		{
			get => GetProperty(ref _videoPath);
			set => SetProperty(ref _videoPath, value);
		}

		[Ordinal(2)] 
		[RED("action")] 
		public CEnum<gameBinkVideoAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		public questEntityManagerManageBinkComponent_NodeTypeParams()
		{
			_action = new() { Value = Enums.gameBinkVideoAction.Start };
		}
	}
}
