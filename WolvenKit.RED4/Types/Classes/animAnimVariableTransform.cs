using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimVariableTransform : animAnimVariable
	{
		[Ordinal(1)] 
		[RED("value")] 
		public QsTransform Value
		{
			get => GetPropertyValue<QsTransform>();
			set => SetPropertyValue<QsTransform>(value);
		}

		[Ordinal(2)] 
		[RED("default")] 
		public QsTransform Default
		{
			get => GetPropertyValue<QsTransform>();
			set => SetPropertyValue<QsTransform>(value);
		}

		public animAnimVariableTransform()
		{
			Value = new QsTransform { Translation = new Vector4 { W = 1.000000F } };
			Default = new QsTransform { Translation = new Vector4 { W = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
