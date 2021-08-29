using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questJumpWorkspotAnim_NodeType : questIBehaviourManager_NodeType
	{
		private CBool _allowCurrAnimToFinish;
		private CInt32 _entryIdToJumpTo;

		[Ordinal(1)] 
		[RED("allowCurrAnimToFinish")] 
		public CBool AllowCurrAnimToFinish
		{
			get => GetProperty(ref _allowCurrAnimToFinish);
			set => SetProperty(ref _allowCurrAnimToFinish, value);
		}

		[Ordinal(2)] 
		[RED("entryIdToJumpTo")] 
		public CInt32 EntryIdToJumpTo
		{
			get => GetProperty(ref _entryIdToJumpTo);
			set => SetProperty(ref _entryIdToJumpTo, value);
		}
	}
}
