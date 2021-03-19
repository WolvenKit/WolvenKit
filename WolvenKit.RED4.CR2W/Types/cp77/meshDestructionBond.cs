using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshDestructionBond : CVariable
	{
		private CUInt16 _bondIndex;
		private CUInt8 _bondHealth;

		[Ordinal(0)] 
		[RED("bondIndex")] 
		public CUInt16 BondIndex
		{
			get => GetProperty(ref _bondIndex);
			set => SetProperty(ref _bondIndex, value);
		}

		[Ordinal(1)] 
		[RED("bondHealth")] 
		public CUInt8 BondHealth
		{
			get => GetProperty(ref _bondHealth);
			set => SetProperty(ref _bondHealth, value);
		}

		public meshDestructionBond(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
