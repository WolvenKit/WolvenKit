using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiScreenProjectionsData : IScriptable
	{
		private CArray<CHandle<inkScreenProjection>> _data;

		[Ordinal(0)] 
		[RED("data")] 
		public CArray<CHandle<inkScreenProjection>> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
