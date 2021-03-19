using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleSpecificCommandParams : ISerializable
	{
		private CBool _pushOtherVehiclesAside;
		private CBool _needDriver;
		private CFloat _secureTimeOut;

		[Ordinal(0)] 
		[RED("pushOtherVehiclesAside")] 
		public CBool PushOtherVehiclesAside
		{
			get => GetProperty(ref _pushOtherVehiclesAside);
			set => SetProperty(ref _pushOtherVehiclesAside, value);
		}

		[Ordinal(1)] 
		[RED("needDriver")] 
		public CBool NeedDriver
		{
			get => GetProperty(ref _needDriver);
			set => SetProperty(ref _needDriver, value);
		}

		[Ordinal(2)] 
		[RED("secureTimeOut")] 
		public CFloat SecureTimeOut
		{
			get => GetProperty(ref _secureTimeOut);
			set => SetProperty(ref _secureTimeOut, value);
		}

		public questVehicleSpecificCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
