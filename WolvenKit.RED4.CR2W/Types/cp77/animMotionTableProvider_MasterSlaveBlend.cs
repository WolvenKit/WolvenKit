using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animMotionTableProvider_MasterSlaveBlend : animIMotionTableProvider
	{
		private CUInt8 _masterInputIdx;

		[Ordinal(5)] 
		[RED("masterInputIdx")] 
		public CUInt8 MasterInputIdx
		{
			get => GetProperty(ref _masterInputIdx);
			set => SetProperty(ref _masterInputIdx, value);
		}

		public animMotionTableProvider_MasterSlaveBlend(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
