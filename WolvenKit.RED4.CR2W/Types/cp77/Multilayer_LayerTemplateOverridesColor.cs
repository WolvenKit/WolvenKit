using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Multilayer_LayerTemplateOverridesColor : CVariable
	{
		private CName _n;
		private CArrayFixedSize<CFloat> _v;

		[Ordinal(0)] 
		[RED("n")] 
		public CName N
		{
			get => GetProperty(ref _n);
			set => SetProperty(ref _n, value);
		}

		[Ordinal(1)] 
		[RED("v", 3)] 
		public CArrayFixedSize<CFloat> V
		{
			get => GetProperty(ref _v);
			set => SetProperty(ref _v, value);
		}

		public Multilayer_LayerTemplateOverridesColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
