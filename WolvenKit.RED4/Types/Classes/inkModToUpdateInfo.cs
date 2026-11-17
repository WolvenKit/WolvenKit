using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkModToUpdateInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("modTitle")] 
		public CString ModTitle
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("authorName")] 
		public CString AuthorName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("modLogoPath")] 
		public CString ModLogoPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("id")] 
		public CInt64 Id
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(4)] 
		[RED("actionsNeeded", 4)] 
		public CStatic<CBool> ActionsNeeded
		{
			get => GetPropertyValue<CStatic<CBool>>();
			set => SetPropertyValue<CStatic<CBool>>(value);
		}

		public inkModToUpdateInfo()
		{
			ActionsNeeded = new(4) { false, false, false, false };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
