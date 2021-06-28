using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FixedPoint : CVariable
	{
		private CInt32 _bits;

		[Ordinal(0)] 
		[RED("Bits")] 
		public CInt32 Bits
		{
			get => GetProperty(ref _bits);
			set => SetProperty(ref _bits, value);
		}

		public FixedPoint(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
