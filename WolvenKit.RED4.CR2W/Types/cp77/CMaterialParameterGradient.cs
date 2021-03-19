using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterGradient : CMaterialParameter
	{
		private rRef<CGradient> _gradient;

		[Ordinal(2)] 
		[RED("gradient")] 
		public rRef<CGradient> Gradient
		{
			get => GetProperty(ref _gradient);
			set => SetProperty(ref _gradient, value);
		}

		public CMaterialParameterGradient(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
