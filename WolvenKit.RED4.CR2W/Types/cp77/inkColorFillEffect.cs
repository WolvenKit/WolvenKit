using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkColorFillEffect : inkIEffect
	{
		private CFloat _colorR;
		private CFloat _colorG;
		private CFloat _colorB;
		private CFloat _colorA;
		private CFloat _saturation;

		[Ordinal(2)] 
		[RED("colorR")] 
		public CFloat ColorR
		{
			get => GetProperty(ref _colorR);
			set => SetProperty(ref _colorR, value);
		}

		[Ordinal(3)] 
		[RED("colorG")] 
		public CFloat ColorG
		{
			get => GetProperty(ref _colorG);
			set => SetProperty(ref _colorG, value);
		}

		[Ordinal(4)] 
		[RED("colorB")] 
		public CFloat ColorB
		{
			get => GetProperty(ref _colorB);
			set => SetProperty(ref _colorB, value);
		}

		[Ordinal(5)] 
		[RED("colorA")] 
		public CFloat ColorA
		{
			get => GetProperty(ref _colorA);
			set => SetProperty(ref _colorA, value);
		}

		[Ordinal(6)] 
		[RED("saturation")] 
		public CFloat Saturation
		{
			get => GetProperty(ref _saturation);
			set => SetProperty(ref _saturation, value);
		}

		public inkColorFillEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
