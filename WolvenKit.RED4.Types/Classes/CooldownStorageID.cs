using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CooldownStorageID : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ID")] 
		public CUInt32 ID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("isValid")] 
		public CEnum<EBOOL> IsValid
		{
			get => GetPropertyValue<CEnum<EBOOL>>();
			set => SetPropertyValue<CEnum<EBOOL>>(value);
		}

		public CooldownStorageID()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
