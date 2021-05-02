using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MorphTargetsTextureBlendInfo : CVariable
	{
		private CBool _blend;
		private CEnum<MorphTargetsDiffTextureSize> _diffSize;
		private CName _name;

		[Ordinal(0)] 
		[RED("blend")] 
		public CBool Blend
		{
			get => GetProperty(ref _blend);
			set => SetProperty(ref _blend, value);
		}

		[Ordinal(1)] 
		[RED("diffSize")] 
		public CEnum<MorphTargetsDiffTextureSize> DiffSize
		{
			get => GetProperty(ref _diffSize);
			set => SetProperty(ref _diffSize, value);
		}

		[Ordinal(2)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		public MorphTargetsTextureBlendInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
