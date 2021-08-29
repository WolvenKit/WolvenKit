using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workWorkspotItemOverrideItemOverride : RedBaseClass
	{
		private TweakDBID _prevItemId;
		private TweakDBID _newItemId;

		[Ordinal(0)] 
		[RED("prevItemId")] 
		public TweakDBID PrevItemId
		{
			get => GetProperty(ref _prevItemId);
			set => SetProperty(ref _prevItemId, value);
		}

		[Ordinal(1)] 
		[RED("newItemId")] 
		public TweakDBID NewItemId
		{
			get => GetProperty(ref _newItemId);
			set => SetProperty(ref _newItemId, value);
		}
	}
}
