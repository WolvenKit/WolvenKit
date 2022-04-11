using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entTriggerActivatorComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("channels")] 
		public CBitField<TriggerChannel> Channels
		{
			get => GetPropertyValue<CBitField<TriggerChannel>>();
			set => SetPropertyValue<CBitField<TriggerChannel>>(value);
		}

		[Ordinal(8)] 
		[RED("maxContinousDistance")] 
		public CFloat MaxContinousDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("enableCCD")] 
		public CBool EnableCCD
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entTriggerActivatorComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			Radius = 0.400000F;
			Height = 1.800000F;
			Channels = Enums.TriggerChannel.TC_Default;
			MaxContinousDistance = 0.100000F;
			IsEnabled = true;
		}
	}
}
