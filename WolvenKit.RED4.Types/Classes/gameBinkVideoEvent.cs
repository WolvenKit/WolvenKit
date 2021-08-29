using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBinkVideoEvent : redEvent
	{
		private CString _videoPath;
		private CEnum<gameBinkVideoAction> _action;

		[Ordinal(0)] 
		[RED("videoPath")] 
		public CString VideoPath
		{
			get => GetProperty(ref _videoPath);
			set => SetProperty(ref _videoPath, value);
		}

		[Ordinal(1)] 
		[RED("action")] 
		public CEnum<gameBinkVideoAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}
	}
}
