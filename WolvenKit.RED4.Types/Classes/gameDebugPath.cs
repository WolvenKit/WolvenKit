using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameDebugPath : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("str")] 
		public CString Str
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public gameDebugPath()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
