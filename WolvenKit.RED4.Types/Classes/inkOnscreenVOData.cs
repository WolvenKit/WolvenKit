using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkOnscreenVOData : RedBaseClass
	{
		private CRUID _text;

		[Ordinal(0)] 
		[RED("text")] 
		public CRUID Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}
	}
}
