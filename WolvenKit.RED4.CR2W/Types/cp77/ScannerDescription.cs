using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerDescription : ScannerChunk
	{
		private CString _defaultFluffDescription;
		private CArray<CString> _customDescriptions;

		[Ordinal(0)] 
		[RED("defaultFluffDescription")] 
		public CString DefaultFluffDescription
		{
			get => GetProperty(ref _defaultFluffDescription);
			set => SetProperty(ref _defaultFluffDescription, value);
		}

		[Ordinal(1)] 
		[RED("customDescriptions")] 
		public CArray<CString> CustomDescriptions
		{
			get => GetProperty(ref _customDescriptions);
			set => SetProperty(ref _customDescriptions, value);
		}

		public ScannerDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
