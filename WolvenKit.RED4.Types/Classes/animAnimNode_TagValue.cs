using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_TagValue : animAnimNode_FloatValue
	{
		private CName _tag;
		private CFloat _defaultValue;
		private CBool _oneMinus;

		[Ordinal(11)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(12)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get => GetProperty(ref _defaultValue);
			set => SetProperty(ref _defaultValue, value);
		}

		[Ordinal(13)] 
		[RED("oneMinus")] 
		public CBool OneMinus
		{
			get => GetProperty(ref _oneMinus);
			set => SetProperty(ref _oneMinus, value);
		}
	}
}
