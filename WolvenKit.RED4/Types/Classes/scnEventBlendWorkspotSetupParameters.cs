using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnEventBlendWorkspotSetupParameters : ISerializable
	{
		[Ordinal(0)] 
		[RED("workspotId")] 
		public scnSceneWorkspotInstanceId WorkspotId
		{
			get => GetPropertyValue<scnSceneWorkspotInstanceId>();
			set => SetPropertyValue<scnSceneWorkspotInstanceId>(value);
		}

		[Ordinal(1)] 
		[RED("sequenceEntryId")] 
		public workWorkEntryId SequenceEntryId
		{
			get => GetPropertyValue<workWorkEntryId>();
			set => SetPropertyValue<workWorkEntryId>(value);
		}

		[Ordinal(2)] 
		[RED("idleOnlyMode")] 
		public CBool IdleOnlyMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("workExcludedGestures")] 
		public CArray<workWorkEntryId> WorkExcludedGestures
		{
			get => GetPropertyValue<CArray<workWorkEntryId>>();
			set => SetPropertyValue<CArray<workWorkEntryId>>(value);
		}

		[Ordinal(4)] 
		[RED("itemOverride")] 
		public workWorkspotItemOverride ItemOverride
		{
			get => GetPropertyValue<workWorkspotItemOverride>();
			set => SetPropertyValue<workWorkspotItemOverride>(value);
		}

		public scnEventBlendWorkspotSetupParameters()
		{
			WorkspotId = new() { Id = 4294967295 };
			SequenceEntryId = new() { Id = 4294967295 };
			IdleOnlyMode = true;
			WorkExcludedGestures = new();
			ItemOverride = new() { PropOverrides = new(), ItemOverrides = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
