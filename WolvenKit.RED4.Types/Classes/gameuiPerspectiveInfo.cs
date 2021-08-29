using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPerspectiveInfo : RedBaseClass
	{
		private CName _name;
		private CName _fpp;
		private CName _tpp;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("fpp")] 
		public CName Fpp
		{
			get => GetProperty(ref _fpp);
			set => SetProperty(ref _fpp, value);
		}

		[Ordinal(2)] 
		[RED("tpp")] 
		public CName Tpp
		{
			get => GetProperty(ref _tpp);
			set => SetProperty(ref _tpp, value);
		}
	}
}
