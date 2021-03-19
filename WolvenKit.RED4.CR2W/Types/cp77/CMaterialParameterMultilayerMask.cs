using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterMultilayerMask : CMaterialParameter
	{
		private rRef<Multilayer_Mask> _mask;

		[Ordinal(2)] 
		[RED("mask")] 
		public rRef<Multilayer_Mask> Mask
		{
			get => GetProperty(ref _mask);
			set => SetProperty(ref _mask, value);
		}

		public CMaterialParameterMultilayerMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
