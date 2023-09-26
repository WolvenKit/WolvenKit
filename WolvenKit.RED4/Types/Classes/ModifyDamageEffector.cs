using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModifyDamageEffector : ModifyAttackEffector
	{
		[Ordinal(0)] 
		[RED("operationType")] 
		public CEnum<EMathOperator> OperationType
		{
			get => GetPropertyValue<CEnum<EMathOperator>>();
			set => SetPropertyValue<CEnum<EMathOperator>>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(3)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(4)] 
		[RED("statListener")] 
		public CHandle<ModifyDamageEffectorStatListener> StatListener
		{
			get => GetPropertyValue<CHandle<ModifyDamageEffectorStatListener>>();
			set => SetPropertyValue<CHandle<ModifyDamageEffectorStatListener>>(value);
		}

		[Ordinal(5)] 
		[RED("statBasedValue")] 
		public CFloat StatBasedValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ModifyDamageEffector()
		{
			StatType = Enums.gamedataStatType.Invalid;
			OwnerID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
