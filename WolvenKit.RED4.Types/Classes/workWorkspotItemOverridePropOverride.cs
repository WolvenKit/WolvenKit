using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workWorkspotItemOverridePropOverride : RedBaseClass
	{
		private CName _prevItemId;
		private CName _newItemId;

		[Ordinal(0)] 
		[RED("prevItemId")] 
		public CName PrevItemId
		{
			get => GetProperty(ref _prevItemId);
			set => SetProperty(ref _prevItemId, value);
		}

		[Ordinal(1)] 
		[RED("newItemId")] 
		public CName NewItemId
		{
			get => GetProperty(ref _newItemId);
			set => SetProperty(ref _newItemId, value);
		}
	}
}
