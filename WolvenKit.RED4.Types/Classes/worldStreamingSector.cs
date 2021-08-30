using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldStreamingSector : CResource
	{
		private CArray<CResourceReference<CResource>> _localInplaceResource;
		private CResourceAsyncReference<worldStreamingSectorInplaceContent> _externInplaceResource;
		private CUInt8 _level;
		private CInt8 _category;

		[Ordinal(1)] 
		[RED("localInplaceResource")] 
		public CArray<CResourceReference<CResource>> LocalInplaceResource
		{
			get => GetProperty(ref _localInplaceResource);
			set => SetProperty(ref _localInplaceResource, value);
		}

		[Ordinal(2)] 
		[RED("externInplaceResource")] 
		public CResourceAsyncReference<worldStreamingSectorInplaceContent> ExternInplaceResource
		{
			get => GetProperty(ref _externInplaceResource);
			set => SetProperty(ref _externInplaceResource, value);
		}

		[Ordinal(3)] 
		[RED("level")] 
		public CUInt8 Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		[Ordinal(4)] 
		[RED("category")] 
		public CInt8 Category
		{
			get => GetProperty(ref _category);
			set => SetProperty(ref _category, value);
		}

		public worldStreamingSector()
		{
			_level = 255;
			_category = -1;
		}
	}
}
