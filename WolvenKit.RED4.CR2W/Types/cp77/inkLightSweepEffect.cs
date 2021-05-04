using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLightSweepEffect : inkIEffect
	{
		private CFloat _positionX;
		private CFloat _positionY;
		private CFloat _angle;
		private CFloat _width;
		private CFloat _intensity;

		[Ordinal(2)] 
		[RED("positionX")] 
		public CFloat PositionX
		{
			get => GetProperty(ref _positionX);
			set => SetProperty(ref _positionX, value);
		}

		[Ordinal(3)] 
		[RED("positionY")] 
		public CFloat PositionY
		{
			get => GetProperty(ref _positionY);
			set => SetProperty(ref _positionY, value);
		}

		[Ordinal(4)] 
		[RED("angle")] 
		public CFloat Angle
		{
			get => GetProperty(ref _angle);
			set => SetProperty(ref _angle, value);
		}

		[Ordinal(5)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(6)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get => GetProperty(ref _intensity);
			set => SetProperty(ref _intensity, value);
		}

		public inkLightSweepEffect(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
