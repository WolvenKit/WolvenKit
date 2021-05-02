using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRidSerialNumber : CVariable
	{
		private CUInt32 _serialNumber;

		[Ordinal(0)] 
		[RED("serialNumber")] 
		public CUInt32 SerialNumber
		{
			get => GetProperty(ref _serialNumber);
			set => SetProperty(ref _serialNumber, value);
		}

		public scnRidSerialNumber(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
