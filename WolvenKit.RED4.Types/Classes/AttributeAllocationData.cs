using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AttributeAllocationData : IScriptable
	{
		[Ordinal(0)] 
		[RED("AttributeType")] 
		public CEnum<gamedataStatType> AttributeType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(1)] 
		[RED("TotalPoints")] 
		public CInt32 TotalPoints
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("AllocatedPoints")] 
		public CInt32 AllocatedPoints
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public AttributeAllocationData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
