using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalPath : IScriptable
	{
		[Ordinal(0)] 
		[RED("realPath")] 
		public CString RealPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("fileEntryIndex")] 
		public CInt32 FileEntryIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameJournalPath()
		{
			FileEntryIndex = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
