using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCombinedStatModifierData : gameStatModifierData
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

		public gameCombinedStatModifierData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
