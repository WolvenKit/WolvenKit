using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRidTag : CVariable
	{
		private CName _signature;
		private scnRidSerialNumber _serialNumber;

		[Ordinal(0)] 
		[RED("signature")] 
		public CName Signature
		{
			get => GetProperty(ref _signature);
			set => SetProperty(ref _signature, value);
		}

		[Ordinal(1)] 
		[RED("serialNumber")] 
		public scnRidSerialNumber SerialNumber
		{
			get => GetProperty(ref _serialNumber);
			set => SetProperty(ref _serialNumber, value);
		}

		public scnRidTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
