using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimVariableTransform : animAnimVariable
	{
		[Ordinal(2)] 
		[RED("value")] 
		public QsTransform Value
		{
			get => GetPropertyValue<QsTransform>();
			set => SetPropertyValue<QsTransform>(value);
		}

		[Ordinal(3)] 
		[RED("default")] 
		public QsTransform Default
		{
			get => GetPropertyValue<QsTransform>();
			set => SetPropertyValue<QsTransform>(value);
		}

		public animAnimVariableTransform()
		{
			Value = new() { Translation = new() { W = 1.000000F }, Rotation = new() { R = 1.000000F }, Scale = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F } };
			Default = new() { Translation = new() { W = 1.000000F }, Rotation = new() { R = 1.000000F }, Scale = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
