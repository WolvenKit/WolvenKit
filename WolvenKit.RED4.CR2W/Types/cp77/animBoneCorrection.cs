using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animBoneCorrection : CVariable
	{
		private CName _boneName;
		private Quaternion _additiveCorrection;

		[Ordinal(0)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get => GetProperty(ref _boneName);
			set => SetProperty(ref _boneName, value);
		}

		[Ordinal(1)] 
		[RED("additiveCorrection")] 
		public Quaternion AdditiveCorrection
		{
			get => GetProperty(ref _additiveCorrection);
			set => SetProperty(ref _additiveCorrection, value);
		}

		public animBoneCorrection(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
