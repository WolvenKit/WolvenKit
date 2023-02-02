using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameGameTimeInterval : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("begin")] 
		public GameTime Begin
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		[Ordinal(1)] 
		[RED("end")] 
		public GameTime End
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		[Ordinal(2)] 
		[RED("ignoreDays")] 
		public CBool IgnoreDays
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameGameTimeInterval()
		{
			Begin = new();
			End = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
