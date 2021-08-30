using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class enteventsSetVisibility : redEvent
	{
		private CBool _visible;
		private CEnum<entVisibilityParamSource> _source;

		[Ordinal(0)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetProperty(ref _visible);
			set => SetProperty(ref _visible, value);
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CEnum<entVisibilityParamSource> Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		public enteventsSetVisibility()
		{
			_visible = true;
		}
	}
}
