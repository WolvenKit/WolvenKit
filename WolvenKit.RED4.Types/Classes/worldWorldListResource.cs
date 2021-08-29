using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldWorldListResource : CResource
	{
		private CArray<worldWorldListResourceEntry> _worlds;

		[Ordinal(1)] 
		[RED("worlds")] 
		public CArray<worldWorldListResourceEntry> Worlds
		{
			get => GetProperty(ref _worlds);
			set => SetProperty(ref _worlds, value);
		}
	}
}
