using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TonemappingModeLottesACES : ITonemappingMode
	{
		private CFloat _maxInput;
		private CFloat _contrast;
		private CFloat _midIn;
		private CFloat _midOut;

		[Ordinal(1)] 
		[RED("maxInput")] 
		public CFloat MaxInput
		{
			get => GetProperty(ref _maxInput);
			set => SetProperty(ref _maxInput, value);
		}

		[Ordinal(2)] 
		[RED("contrast")] 
		public CFloat Contrast
		{
			get => GetProperty(ref _contrast);
			set => SetProperty(ref _contrast, value);
		}

		[Ordinal(3)] 
		[RED("midIn")] 
		public CFloat MidIn
		{
			get => GetProperty(ref _midIn);
			set => SetProperty(ref _midIn, value);
		}

		[Ordinal(4)] 
		[RED("midOut")] 
		public CFloat MidOut
		{
			get => GetProperty(ref _midOut);
			set => SetProperty(ref _midOut, value);
		}

		public TonemappingModeLottesACES(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
