using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiRoadEditorSegment : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("length")] 
		public CUInt32 Length
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("curve")] 
		public CFloat Curve
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("hasCheckpoint")] 
		public CBool HasCheckpoint
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("obstacleSettings")] 
		public CArray<gameuiRoadEditorObstacleSettings> ObstacleSettings
		{
			get => GetPropertyValue<CArray<gameuiRoadEditorObstacleSettings>>();
			set => SetPropertyValue<CArray<gameuiRoadEditorObstacleSettings>>(value);
		}

		[Ordinal(4)] 
		[RED("decorationSettings")] 
		public CArray<gameuiRoadEditorDecorationSettings> DecorationSettings
		{
			get => GetPropertyValue<CArray<gameuiRoadEditorDecorationSettings>>();
			set => SetPropertyValue<CArray<gameuiRoadEditorDecorationSettings>>(value);
		}

		public gameuiRoadEditorSegment()
		{
			ObstacleSettings = new();
			DecorationSettings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
