using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiScreenProjectionsData : IScriptable
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CArray<CHandle<inkScreenProjection>> Data
		{
			get => GetPropertyValue<CArray<CHandle<inkScreenProjection>>>();
			set => SetPropertyValue<CArray<CHandle<inkScreenProjection>>>(value);
		}

		public gameuiScreenProjectionsData()
		{
			Data = new();
		}
	}
}
