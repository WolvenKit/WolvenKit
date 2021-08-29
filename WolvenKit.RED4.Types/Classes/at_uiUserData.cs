using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class at_uiUserData : inkUserData
	{
		private CString _atid;

		[Ordinal(0)] 
		[RED("atid")] 
		public CString Atid
		{
			get => GetProperty(ref _atid);
			set => SetProperty(ref _atid, value);
		}
	}
}
