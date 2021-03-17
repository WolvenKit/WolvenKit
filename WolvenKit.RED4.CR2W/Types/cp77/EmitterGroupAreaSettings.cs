using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EmitterGroupAreaSettings : IAreaSettings
	{
		private CArray<EmitterGroupParams> _emitterGroupParams_72;
		private CArray<EmitterGroupAreaParams> _emitterGroupParams_88;

		[Ordinal(2)] 
		[RED("emitterGroupParams")] 
		public CArray<EmitterGroupParams> EmitterGroupParams_72
		{
			get => GetProperty(ref _emitterGroupParams_72);
			set => SetProperty(ref _emitterGroupParams_72, value);
		}

		[Ordinal(3)] 
		[RED("EmitterGroupParams")] 
		public CArray<EmitterGroupAreaParams> EmitterGroupParams_88
		{
			get => GetProperty(ref _emitterGroupParams_88);
			set => SetProperty(ref _emitterGroupParams_88, value);
		}

		public EmitterGroupAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
