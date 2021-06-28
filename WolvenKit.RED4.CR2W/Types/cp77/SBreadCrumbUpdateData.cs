using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SBreadCrumbUpdateData : CVariable
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

		public SBreadCrumbUpdateData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
