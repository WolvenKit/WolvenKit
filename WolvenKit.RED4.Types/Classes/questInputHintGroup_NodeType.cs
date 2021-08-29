using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questInputHintGroup_NodeType : questIUIManagerNodeType
	{
		private CBool _show;
		private TweakDBID _iconID;
		private CName _groupId;
		private CString _localizedTitle;
		private CString _localizedDescription;

		[Ordinal(0)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetProperty(ref _show);
			set => SetProperty(ref _show, value);
		}

		[Ordinal(1)] 
		[RED("iconID")] 
		public TweakDBID IconID
		{
			get => GetProperty(ref _iconID);
			set => SetProperty(ref _iconID, value);
		}

		[Ordinal(2)] 
		[RED("groupId")] 
		public CName GroupId
		{
			get => GetProperty(ref _groupId);
			set => SetProperty(ref _groupId, value);
		}

		[Ordinal(3)] 
		[RED("localizedTitle")] 
		public CString LocalizedTitle
		{
			get => GetProperty(ref _localizedTitle);
			set => SetProperty(ref _localizedTitle, value);
		}

		[Ordinal(4)] 
		[RED("localizedDescription")] 
		public CString LocalizedDescription
		{
			get => GetProperty(ref _localizedDescription);
			set => SetProperty(ref _localizedDescription, value);
		}
	}
}
