using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInjectLoot_NodeTypeParams_OperationData : CVariable
	{
		private CEnum<questInjectLootOperationType> _operationType;
		private TweakDBID _itemTDBID;
		private CInt32 _quantity;

		[Ordinal(0)] 
		[RED("operationType")] 
		public CEnum<questInjectLootOperationType> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}

		[Ordinal(1)] 
		[RED("itemTDBID")] 
		public TweakDBID ItemTDBID
		{
			get => GetProperty(ref _itemTDBID);
			set => SetProperty(ref _itemTDBID, value);
		}

		[Ordinal(2)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		public questInjectLoot_NodeTypeParams_OperationData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
