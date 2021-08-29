using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnEventBlendWorkspotSetupParameters : ISerializable
	{
		private scnSceneWorkspotInstanceId _workspotId;
		private workWorkEntryId _sequenceEntryId;
		private CBool _idleOnlyMode;
		private CArray<workWorkEntryId> _workExcludedGestures;
		private workWorkspotItemOverride _itemOverride;

		[Ordinal(0)] 
		[RED("workspotId")] 
		public scnSceneWorkspotInstanceId WorkspotId
		{
			get => GetProperty(ref _workspotId);
			set => SetProperty(ref _workspotId, value);
		}

		[Ordinal(1)] 
		[RED("sequenceEntryId")] 
		public workWorkEntryId SequenceEntryId
		{
			get => GetProperty(ref _sequenceEntryId);
			set => SetProperty(ref _sequenceEntryId, value);
		}

		[Ordinal(2)] 
		[RED("idleOnlyMode")] 
		public CBool IdleOnlyMode
		{
			get => GetProperty(ref _idleOnlyMode);
			set => SetProperty(ref _idleOnlyMode, value);
		}

		[Ordinal(3)] 
		[RED("workExcludedGestures")] 
		public CArray<workWorkEntryId> WorkExcludedGestures
		{
			get => GetProperty(ref _workExcludedGestures);
			set => SetProperty(ref _workExcludedGestures, value);
		}

		[Ordinal(4)] 
		[RED("itemOverride")] 
		public workWorkspotItemOverride ItemOverride
		{
			get => GetProperty(ref _itemOverride);
			set => SetProperty(ref _itemOverride, value);
		}
	}
}
