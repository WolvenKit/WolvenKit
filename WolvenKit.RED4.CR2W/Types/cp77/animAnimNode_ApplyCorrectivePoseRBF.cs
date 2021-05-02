using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ApplyCorrectivePoseRBF : animAnimNode_OnePoseInput
	{
		private CFloat _rbfCoefficient;
		private CFloat _rbfPowValue;
		private CFloat _correctiveFrame;
		private CArray<animCorrectivePoseEntry> _correctives;

		[Ordinal(12)] 
		[RED("rbfCoefficient")] 
		public CFloat RbfCoefficient
		{
			get => GetProperty(ref _rbfCoefficient);
			set => SetProperty(ref _rbfCoefficient, value);
		}

		[Ordinal(13)] 
		[RED("rbfPowValue")] 
		public CFloat RbfPowValue
		{
			get => GetProperty(ref _rbfPowValue);
			set => SetProperty(ref _rbfPowValue, value);
		}

		[Ordinal(14)] 
		[RED("correctiveFrame")] 
		public CFloat CorrectiveFrame
		{
			get => GetProperty(ref _correctiveFrame);
			set => SetProperty(ref _correctiveFrame, value);
		}

		[Ordinal(15)] 
		[RED("correctives")] 
		public CArray<animCorrectivePoseEntry> Correctives
		{
			get => GetProperty(ref _correctives);
			set => SetProperty(ref _correctives, value);
		}

		public animAnimNode_ApplyCorrectivePoseRBF(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
