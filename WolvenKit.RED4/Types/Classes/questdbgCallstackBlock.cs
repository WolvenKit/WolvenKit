using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questdbgCallstackBlock : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CUInt64 Id
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("parentId")] 
		public CUInt64 ParentId
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public questdbgCallstackBlock()
		{
			Id = 18446744073709551615;
			ParentId = 18446744073709551615;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
