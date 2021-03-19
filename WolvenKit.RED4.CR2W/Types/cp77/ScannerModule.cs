using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerModule : HUDModule
	{
		private CArray<CHandle<ScanInstance>> _activeScans;

		[Ordinal(3)] 
		[RED("activeScans")] 
		public CArray<CHandle<ScanInstance>> ActiveScans
		{
			get => GetProperty(ref _activeScans);
			set => SetProperty(ref _activeScans, value);
		}

		public ScannerModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
