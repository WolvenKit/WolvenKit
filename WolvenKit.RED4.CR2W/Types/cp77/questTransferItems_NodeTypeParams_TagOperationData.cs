using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTransferItems_NodeTypeParams_TagOperationData : CVariable
	{
		private CName _tagToTransfer;
		private CArray<TweakDBID> _itemIDsToIgnore;
		private CArray<CName> _tagsToIgnore;

		[Ordinal(0)] 
		[RED("tagToTransfer")] 
		public CName TagToTransfer
		{
			get => GetProperty(ref _tagToTransfer);
			set => SetProperty(ref _tagToTransfer, value);
		}

		[Ordinal(1)] 
		[RED("itemIDsToIgnore")] 
		public CArray<TweakDBID> ItemIDsToIgnore
		{
			get => GetProperty(ref _itemIDsToIgnore);
			set => SetProperty(ref _itemIDsToIgnore, value);
		}

		[Ordinal(2)] 
		[RED("tagsToIgnore")] 
		public CArray<CName> TagsToIgnore
		{
			get => GetProperty(ref _tagsToIgnore);
			set => SetProperty(ref _tagsToIgnore, value);
		}

		public questTransferItems_NodeTypeParams_TagOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
