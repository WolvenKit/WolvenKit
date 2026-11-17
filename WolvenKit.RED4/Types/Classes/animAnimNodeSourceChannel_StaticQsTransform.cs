using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNodeSourceChannel_StaticQsTransform : animIAnimNodeSourceChannel_QsTransform
	{
		[Ordinal(0)] 
		[RED("data")] 
		public QsTransform Data
		{
			get => GetPropertyValue<QsTransform>();
			set => SetPropertyValue<QsTransform>(value);
		}

		public animAnimNodeSourceChannel_StaticQsTransform()
		{
			Data = new QsTransform();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
