using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopStringWithID : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("text")] 
		public CString Text
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CUInt64 Id
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public interopStringWithID()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
