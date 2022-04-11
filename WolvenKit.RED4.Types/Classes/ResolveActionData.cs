using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResolveActionData : IScriptable
	{
		[Ordinal(0)] 
		[RED("password")] 
		public CString Password
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
