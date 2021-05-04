using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerVehicleHorsepower : ScannerChunk
	{
		private CInt32 _horsepower;

		[Ordinal(0)] 
		[RED("horsepower")] 
		public CInt32 Horsepower
		{
			get => GetProperty(ref _horsepower);
			set => SetProperty(ref _horsepower, value);
		}

		public ScannerVehicleHorsepower(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
