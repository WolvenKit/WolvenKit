using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WorkspotEntryData : IScriptable
	{
		private NodeRef _workspotRef;
		private CBool _isEnabled;
		private CBool _isAvailable;

		[Ordinal(0)] 
		[RED("workspotRef")] 
		public NodeRef WorkspotRef
		{
			get => GetProperty(ref _workspotRef);
			set => SetProperty(ref _workspotRef, value);
		}

		[Ordinal(1)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(2)] 
		[RED("isAvailable")] 
		public CBool IsAvailable
		{
			get => GetProperty(ref _isAvailable);
			set => SetProperty(ref _isAvailable, value);
		}

		public WorkspotEntryData()
		{
			_isAvailable = true;
		}
	}
}
