using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questTransferItems_NodeTypeParams_TransferAllOperationData : ISerializable
	{
		private CArray<TweakDBID> _itemIDsToIgnore;
		private CArray<CName> _tagsToIgnore;

		[Ordinal(0)] 
		[RED("itemIDsToIgnore")] 
		public CArray<TweakDBID> ItemIDsToIgnore
		{
			get => GetProperty(ref _itemIDsToIgnore);
			set => SetProperty(ref _itemIDsToIgnore, value);
		}

		[Ordinal(1)] 
		[RED("tagsToIgnore")] 
		public CArray<CName> TagsToIgnore
		{
			get => GetProperty(ref _tagsToIgnore);
			set => SetProperty(ref _tagsToIgnore, value);
		}
	}
}
