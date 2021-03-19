using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlayerAnimData : CVariable
	{
		private CHandle<gameSceneTierData> _tierData;
		private CBool _useZSnapping;
		private CBool _unmountBodyCarry;

		[Ordinal(0)] 
		[RED("tierData")] 
		public CHandle<gameSceneTierData> TierData
		{
			get => GetProperty(ref _tierData);
			set => SetProperty(ref _tierData, value);
		}

		[Ordinal(1)] 
		[RED("useZSnapping")] 
		public CBool UseZSnapping
		{
			get => GetProperty(ref _useZSnapping);
			set => SetProperty(ref _useZSnapping, value);
		}

		[Ordinal(2)] 
		[RED("unmountBodyCarry")] 
		public CBool UnmountBodyCarry
		{
			get => GetProperty(ref _unmountBodyCarry);
			set => SetProperty(ref _unmountBodyCarry, value);
		}

		public scnPlayerAnimData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
