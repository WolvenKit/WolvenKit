using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TonemappingModeACES : ITonemappingMode
	{
		private STonemappingACESParams _params;

		[Ordinal(1)] 
		[RED("params")] 
		public STonemappingACESParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		public TonemappingModeACES(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
