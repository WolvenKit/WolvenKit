using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CColor_ : CVariable
	{
		private CUInt8 _red;
		private CUInt8 _green;
		private CUInt8 _blue;
		private CUInt8 _alpha;

		[Ordinal(0)] 
		[RED("Red")] 
		public CUInt8 Red
		{
			get => GetProperty(ref _red);
			set => SetProperty(ref _red, value);
		}

		[Ordinal(1)] 
		[RED("Green")] 
		public CUInt8 Green
		{
			get => GetProperty(ref _green);
			set => SetProperty(ref _green, value);
		}

		[Ordinal(2)] 
		[RED("Blue")] 
		public CUInt8 Blue
		{
			get => GetProperty(ref _blue);
			set => SetProperty(ref _blue, value);
		}

		[Ordinal(3)] 
		[RED("Alpha")] 
		public CUInt8 Alpha
		{
			get => GetProperty(ref _alpha);
			set => SetProperty(ref _alpha, value);
		}

		public CColor_(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
