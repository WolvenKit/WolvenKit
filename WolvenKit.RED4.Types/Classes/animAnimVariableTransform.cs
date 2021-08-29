using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimVariableTransform : animAnimVariable
	{
		private QsTransform _value;
		private QsTransform _default;

		[Ordinal(2)] 
		[RED("value")] 
		public QsTransform Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(3)] 
		[RED("default")] 
		public QsTransform Default
		{
			get => GetProperty(ref _default);
			set => SetProperty(ref _default, value);
		}
	}
}
