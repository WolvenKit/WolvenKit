using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BenchmarkLineData : IScriptable
	{
		[Ordinal(0)] 
		[RED("label")] 
		public CString Label
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CString Value
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public BenchmarkLineData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
