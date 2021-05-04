using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnGenderMask : CVariable
	{
		private CUInt8 _mask;

		[Ordinal(0)] 
		[RED("mask")] 
		public CUInt8 Mask
		{
			get => GetProperty(ref _mask);
			set => SetProperty(ref _mask, value);
		}

		public scnGenderMask(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
