using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questProgressBar_NodeType : questIUIManagerNodeType
	{
		private CBool _show;
		private CFloat _duration;
		private LocalizationString _text;

		[Ordinal(0)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetProperty(ref _show);
			set => SetProperty(ref _show, value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(2)] 
		[RED("text")] 
		public LocalizationString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		public questProgressBar_NodeType()
		{
			_show = true;
			_duration = 3.000000F;
		}
	}
}
