using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModifyDamageWithStatPoolEffector : ModifyDamageEffector
	{
		[Ordinal(2)] 
		[RED("statPool")] 
		public CEnum<gamedataStatPoolType> StatPool
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		[Ordinal(3)] 
		[RED("poolStatus")] 
		public CString PoolStatus
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("maxDmg")] 
		public CFloat MaxDmg
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("refObj")] 
		public CString RefObj
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public ModifyDamageWithStatPoolEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
