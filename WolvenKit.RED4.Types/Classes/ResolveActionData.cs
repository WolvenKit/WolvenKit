using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResolveActionData : IScriptable
	{
		private CString _password;

		[Ordinal(0)] 
		[RED("password")] 
		public CString Password
		{
			get => GetProperty(ref _password);
			set => SetProperty(ref _password, value);
		}
	}
}
