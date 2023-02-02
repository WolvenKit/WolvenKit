using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTransferItems_NodeTypeParams_TagOperationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("tagToTransfer")] 
		public CName TagToTransfer
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("itemIDsToIgnore")] 
		public CArray<TweakDBID> ItemIDsToIgnore
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(2)] 
		[RED("tagsToIgnore")] 
		public CArray<CName> TagsToIgnore
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public questTransferItems_NodeTypeParams_TagOperationData()
		{
			ItemIDsToIgnore = new();
			TagsToIgnore = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
