using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TarotCardData : RedBaseClass
	{
		private CBool _empty;
		private CInt32 _index;
		private CName _imagePath;
		private CString _label;
		private CString _desc;

		[Ordinal(0)] 
		[RED("empty")] 
		public CBool Empty
		{
			get => GetProperty(ref _empty);
			set => SetProperty(ref _empty, value);
		}

		[Ordinal(1)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(2)] 
		[RED("imagePath")] 
		public CName ImagePath
		{
			get => GetProperty(ref _imagePath);
			set => SetProperty(ref _imagePath, value);
		}

		[Ordinal(3)] 
		[RED("label")] 
		public CString Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(4)] 
		[RED("desc")] 
		public CString Desc
		{
			get => GetProperty(ref _desc);
			set => SetProperty(ref _desc, value);
		}
	}
}
