using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ResolveActionData : IScriptable
	{
		[Ordinal(0)] 
		[RED("password")] 
		public CString Password
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public ResolveActionData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
