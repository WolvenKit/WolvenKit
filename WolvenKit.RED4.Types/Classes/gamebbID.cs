using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamebbID : RedBaseClass
	{
		private CName _g;

		[Ordinal(0)] 
		[RED("g")] 
		public CName G
		{
			get => GetProperty(ref _g);
			set => SetProperty(ref _g, value);
		}
	}
}
