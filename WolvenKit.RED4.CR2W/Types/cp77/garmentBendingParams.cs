using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class garmentBendingParams : CVariable
	{
		private CFloat _bendPowerOffsetInCM;

		[Ordinal(0)] 
		[RED("bendPowerOffsetInCM")] 
		public CFloat BendPowerOffsetInCM
		{
			get => GetProperty(ref _bendPowerOffsetInCM);
			set => SetProperty(ref _bendPowerOffsetInCM, value);
		}

		public garmentBendingParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
