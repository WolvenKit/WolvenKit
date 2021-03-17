using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerVehicleMass : ScannerChunk
	{
		private CInt32 _mass;

		[Ordinal(0)] 
		[RED("mass")] 
		public CInt32 Mass
		{
			get => GetProperty(ref _mass);
			set => SetProperty(ref _mass, value);
		}

		public ScannerVehicleMass(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
