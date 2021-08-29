using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForcedVisibilityInAnimSystemData : IScriptable
	{
		private CName _sourceName;
		private gameDelayID _delayID;
		private CBool _forcedVisibleOnlyInFrustum;

		[Ordinal(0)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get => GetProperty(ref _sourceName);
			set => SetProperty(ref _sourceName, value);
		}

		[Ordinal(1)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get => GetProperty(ref _delayID);
			set => SetProperty(ref _delayID, value);
		}

		[Ordinal(2)] 
		[RED("forcedVisibleOnlyInFrustum")] 
		public CBool ForcedVisibleOnlyInFrustum
		{
			get => GetProperty(ref _forcedVisibleOnlyInFrustum);
			set => SetProperty(ref _forcedVisibleOnlyInFrustum, value);
		}
	}
}
