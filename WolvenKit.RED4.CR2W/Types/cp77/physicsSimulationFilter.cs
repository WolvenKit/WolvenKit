using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsSimulationFilter : CVariable
	{
		private CUInt64 _mask1;
		private CUInt64 _mask2;

		[Ordinal(0)] 
		[RED("mask1")] 
		public CUInt64 Mask1
		{
			get => GetProperty(ref _mask1);
			set => SetProperty(ref _mask1, value);
		}

		[Ordinal(1)] 
		[RED("mask2")] 
		public CUInt64 Mask2
		{
			get => GetProperty(ref _mask2);
			set => SetProperty(ref _mask2, value);
		}

		public physicsSimulationFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
