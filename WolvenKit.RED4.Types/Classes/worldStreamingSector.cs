using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStreamingSector : CResource
	{
		[Ordinal(1)] 
		[RED("localInplaceResource")] 
		public CArray<CResourceReference<CResource>> LocalInplaceResource
		{
			get => GetPropertyValue<CArray<CResourceReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceReference<CResource>>>(value);
		}

		[Ordinal(2)] 
		[RED("externInplaceResource")] 
		public CResourceAsyncReference<worldStreamingSectorInplaceContent> ExternInplaceResource
		{
			get => GetPropertyValue<CResourceAsyncReference<worldStreamingSectorInplaceContent>>();
			set => SetPropertyValue<CResourceAsyncReference<worldStreamingSectorInplaceContent>>(value);
		}

		[Ordinal(3)] 
		[RED("level")] 
		public CUInt8 Level
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(4)] 
		[RED("category")] 
		public CEnum<worldStreamingSectorCategory> Category
		{
			get => GetPropertyValue<CEnum<worldStreamingSectorCategory>>();
			set => SetPropertyValue<CEnum<worldStreamingSectorCategory>>(value);
		}

		public worldStreamingSector()
		{
			LocalInplaceResource = new();
			Level = 255;
			Category = Enums.worldStreamingSectorCategory.Unknown;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
