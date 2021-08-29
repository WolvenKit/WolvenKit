using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MenuDataBuilder : IScriptable
	{
		private CArray<MenuData> _data;

		[Ordinal(0)] 
		[RED("data")] 
		public CArray<MenuData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
