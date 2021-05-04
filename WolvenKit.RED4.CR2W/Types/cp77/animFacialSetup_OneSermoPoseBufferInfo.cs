using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animFacialSetup_OneSermoPoseBufferInfo : CVariable
	{
		private CUInt16 _numMainPoses;
		private CUInt16 _numCorrectivePoses;
		private CUInt32 _numMainTransforms;
		private CUInt32 _numMainScales;
		private CUInt32 _numCorrectiveTransforms;
		private CUInt32 _numCorrectiveScales;

		[Ordinal(0)] 
		[RED("numMainPoses")] 
		public CUInt16 NumMainPoses
		{
			get => GetProperty(ref _numMainPoses);
			set => SetProperty(ref _numMainPoses, value);
		}

		[Ordinal(1)] 
		[RED("numCorrectivePoses")] 
		public CUInt16 NumCorrectivePoses
		{
			get => GetProperty(ref _numCorrectivePoses);
			set => SetProperty(ref _numCorrectivePoses, value);
		}

		[Ordinal(2)] 
		[RED("numMainTransforms")] 
		public CUInt32 NumMainTransforms
		{
			get => GetProperty(ref _numMainTransforms);
			set => SetProperty(ref _numMainTransforms, value);
		}

		[Ordinal(3)] 
		[RED("numMainScales")] 
		public CUInt32 NumMainScales
		{
			get => GetProperty(ref _numMainScales);
			set => SetProperty(ref _numMainScales, value);
		}

		[Ordinal(4)] 
		[RED("numCorrectiveTransforms")] 
		public CUInt32 NumCorrectiveTransforms
		{
			get => GetProperty(ref _numCorrectiveTransforms);
			set => SetProperty(ref _numCorrectiveTransforms, value);
		}

		[Ordinal(5)] 
		[RED("numCorrectiveScales")] 
		public CUInt32 NumCorrectiveScales
		{
			get => GetProperty(ref _numCorrectiveScales);
			set => SetProperty(ref _numCorrectiveScales, value);
		}

		public animFacialSetup_OneSermoPoseBufferInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
