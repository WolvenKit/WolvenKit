using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioFoleyNPCMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("fastHeavy")] 
		public audioMeleeSound FastHeavy
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(2)] 
		[RED("fastMedium")] 
		public audioMeleeSound FastMedium
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(3)] 
		[RED("fastLight")] 
		public audioMeleeSound FastLight
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(4)] 
		[RED("normalHeavy")] 
		public audioMeleeSound NormalHeavy
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(5)] 
		[RED("normalMedium")] 
		public audioMeleeSound NormalMedium
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(6)] 
		[RED("normalLight")] 
		public audioMeleeSound NormalLight
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(7)] 
		[RED("slowHeavy")] 
		public audioMeleeSound SlowHeavy
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(8)] 
		[RED("slowMedium")] 
		public audioMeleeSound SlowMedium
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(9)] 
		[RED("slowLight")] 
		public audioMeleeSound SlowLight
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(10)] 
		[RED("walk")] 
		public audioMeleeSound Walk
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(11)] 
		[RED("run")] 
		public audioMeleeSound Run
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		public audioFoleyNPCMetadata()
		{
			FastHeavy = new audioMeleeSound { Events = new() };
			FastMedium = new audioMeleeSound { Events = new() };
			FastLight = new audioMeleeSound { Events = new() };
			NormalHeavy = new audioMeleeSound { Events = new() };
			NormalMedium = new audioMeleeSound { Events = new() };
			NormalLight = new audioMeleeSound { Events = new() };
			SlowHeavy = new audioMeleeSound { Events = new() };
			SlowMedium = new audioMeleeSound { Events = new() };
			SlowLight = new audioMeleeSound { Events = new() };
			Walk = new audioMeleeSound { Events = new() };
			Run = new audioMeleeSound { Events = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
