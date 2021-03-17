using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerResistances : ScannerChunk
	{
		private CArray<ScannerStatDetails> _resists;

		[Ordinal(0)] 
		[RED("resists")] 
		public CArray<ScannerStatDetails> Resists
		{
			get => GetProperty(ref _resists);
			set => SetProperty(ref _resists, value);
		}

		public ScannerResistances(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
