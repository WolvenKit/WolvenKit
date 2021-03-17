using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendHistogramBias : CVariable
	{
		private Vector3 _mulCoef;
		private Vector3 _addCoef;

		[Ordinal(0)] 
		[RED("mulCoef")] 
		public Vector3 MulCoef
		{
			get => GetProperty(ref _mulCoef);
			set => SetProperty(ref _mulCoef, value);
		}

		[Ordinal(1)] 
		[RED("addCoef")] 
		public Vector3 AddCoef
		{
			get => GetProperty(ref _addCoef);
			set => SetProperty(ref _addCoef, value);
		}

		public rendHistogramBias(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
