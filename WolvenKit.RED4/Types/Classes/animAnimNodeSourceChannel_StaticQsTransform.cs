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
			Data = new QsTransform { Translation = new Vector4(), Rotation = new Quaternion { R = 1.000000F }, Scale = new Vector4 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
