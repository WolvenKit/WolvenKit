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
			Id = ulong.MaxValue;
			ParentId = ulong.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
