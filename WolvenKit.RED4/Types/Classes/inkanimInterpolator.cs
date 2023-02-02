using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimInterpolator : IScriptable
	{
		[Ordinal(0)] 
		[RED("interpolationMode")] 
		public CEnum<inkanimInterpolationMode> InterpolationMode
		{
			get => GetPropertyValue<CEnum<inkanimInterpolationMode>>();
			set => SetPropertyValue<CEnum<inkanimInterpolationMode>>(value);
		}

		[Ordinal(1)] 
		[RED("interpolationType")] 
		public CEnum<inkanimInterpolationType> InterpolationType
		{
			get => GetPropertyValue<CEnum<inkanimInterpolationType>>();
			set => SetPropertyValue<CEnum<inkanimInterpolationType>>(value);
		}

		[Ordinal(2)] 
		[RED("interpolationDirection")] 
		public CEnum<inkanimInterpolationDirection> InterpolationDirection
		{
			get => GetPropertyValue<CEnum<inkanimInterpolationDirection>>();
			set => SetPropertyValue<CEnum<inkanimInterpolationDirection>>(value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("startDelay")] 
		public CFloat StartDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("useRelativeDuration")] 
		public CBool UseRelativeDuration
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isAdditive")] 
		public CBool IsAdditive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public inkanimInterpolator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
