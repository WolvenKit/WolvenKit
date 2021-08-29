using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimVariableBool : animAnimVariable
	{
		private CBool _value;
		private CBool _default;

		[Ordinal(2)] 
		[RED("value")] 
		public CBool Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(3)] 
		[RED("default")] 
		public CBool Default
		{
			get => GetProperty(ref _default);
			set => SetProperty(ref _default, value);
		}
	}
}
