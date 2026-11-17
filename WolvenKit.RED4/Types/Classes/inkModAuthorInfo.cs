using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkModAuthorInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("authorId")] 
		public CInt64 AuthorId
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(1)] 
		[RED("username")] 
		public CString Username
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public inkModAuthorInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
