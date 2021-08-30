using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCombinedStatModifierData_Deprecated : gameStatModifierData_Deprecated
	{
		private CEnum<gamedataStatType> _refStatType;
		private CEnum<gameCombinedStatOperation> _operation;
		private CEnum<gameStatObjectsRelation> _refObject;
		private CFloat _value;

		[Ordinal(2)] 
		[RED("refStatType")] 
		public CEnum<gamedataStatType> RefStatType
		{
			get => GetProperty(ref _refStatType);
			set => SetProperty(ref _refStatType, value);
		}

		[Ordinal(3)] 
		[RED("operation")] 
		public CEnum<gameCombinedStatOperation> Operation
		{
			get => GetProperty(ref _operation);
			set => SetProperty(ref _operation, value);
		}

		[Ordinal(4)] 
		[RED("refObject")] 
		public CEnum<gameStatObjectsRelation> RefObject
		{
			get => GetProperty(ref _refObject);
			set => SetProperty(ref _refObject, value);
		}

		[Ordinal(5)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public gameCombinedStatModifierData_Deprecated()
		{
			_refStatType = new() { Value = Enums.gamedataStatType.Invalid };
			_operation = new() { Value = Enums.gameCombinedStatOperation.Invalid };
			_refObject = new() { Value = Enums.gameStatObjectsRelation.Invalid };
		}
	}
}
