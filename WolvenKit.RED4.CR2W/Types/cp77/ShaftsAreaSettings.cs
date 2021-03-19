using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShaftsAreaSettings : CVariable
	{
		private CUInt32 _shaftsLevelIndex;
		private CFloat _shaftsIntensity;
		private CFloat _shaftsThresholdsScale;

		[Ordinal(0)] 
		[RED("shaftsLevelIndex")] 
		public CUInt32 ShaftsLevelIndex
		{
			get => GetProperty(ref _shaftsLevelIndex);
			set => SetProperty(ref _shaftsLevelIndex, value);
		}

		[Ordinal(1)] 
		[RED("shaftsIntensity")] 
		public CFloat ShaftsIntensity
		{
			get => GetProperty(ref _shaftsIntensity);
			set => SetProperty(ref _shaftsIntensity, value);
		}

		[Ordinal(2)] 
		[RED("shaftsThresholdsScale")] 
		public CFloat ShaftsThresholdsScale
		{
			get => GetProperty(ref _shaftsThresholdsScale);
			set => SetProperty(ref _shaftsThresholdsScale, value);
		}

		public ShaftsAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
