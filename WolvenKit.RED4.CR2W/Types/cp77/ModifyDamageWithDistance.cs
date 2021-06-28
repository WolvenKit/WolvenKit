using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyDamageWithDistance : ModifyDamageEffector
	{
		private CBool _increaseWithDistance;
		private CFloat _percentMult;
		private CFloat _unitThreshold;

		[Ordinal(2)] 
		[RED("increaseWithDistance")] 
		public CBool IncreaseWithDistance
		{
			get => GetProperty(ref _increaseWithDistance);
			set => SetProperty(ref _increaseWithDistance, value);
		}

		[Ordinal(3)] 
		[RED("percentMult")] 
		public CFloat PercentMult
		{
			get => GetProperty(ref _percentMult);
			set => SetProperty(ref _percentMult, value);
		}

		[Ordinal(4)] 
		[RED("unitThreshold")] 
		public CFloat UnitThreshold
		{
			get => GetProperty(ref _unitThreshold);
			set => SetProperty(ref _unitThreshold, value);
		}

		public ModifyDamageWithDistance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
