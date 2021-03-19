using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickSlotUIStructure : CVariable
	{
		private CInt32 _itemIndex;
		private CBool _operationResult;

		[Ordinal(0)] 
		[RED("ItemIndex")] 
		public CInt32 ItemIndex
		{
			get => GetProperty(ref _itemIndex);
			set => SetProperty(ref _itemIndex, value);
		}

		[Ordinal(1)] 
		[RED("OperationResult")] 
		public CBool OperationResult
		{
			get => GetProperty(ref _operationResult);
			set => SetProperty(ref _operationResult, value);
		}

		public QuickSlotUIStructure(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
