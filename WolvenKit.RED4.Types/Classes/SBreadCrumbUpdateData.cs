using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SBreadCrumbUpdateData : RedBaseClass
	{
		private CString _elementName;
		private CInt32 _elementID;
		private CName _context;

		[Ordinal(0)] 
		[RED("elementName")] 
		public CString ElementName
		{
			get => GetProperty(ref _elementName);
			set => SetProperty(ref _elementName, value);
		}

		[Ordinal(1)] 
		[RED("elementID")] 
		public CInt32 ElementID
		{
			get => GetProperty(ref _elementID);
			set => SetProperty(ref _elementID, value);
		}

		[Ordinal(2)] 
		[RED("context")] 
		public CName Context
		{
			get => GetProperty(ref _context);
			set => SetProperty(ref _context, value);
		}
	}
}
