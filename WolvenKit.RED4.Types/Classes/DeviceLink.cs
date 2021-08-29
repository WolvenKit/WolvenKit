using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceLink : RedBaseClass
	{
		private gamePersistentID _pSID;
		private CName _className;

		[Ordinal(0)] 
		[RED("PSID")] 
		public gamePersistentID PSID
		{
			get => GetProperty(ref _pSID);
			set => SetProperty(ref _pSID, value);
		}

		[Ordinal(1)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetProperty(ref _className);
			set => SetProperty(ref _className, value);
		}
	}
}
