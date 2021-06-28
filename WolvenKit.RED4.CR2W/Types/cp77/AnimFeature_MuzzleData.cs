using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_MuzzleData : animAnimFeature
	{
		private Vector4 _muzzleOffset;

		[Ordinal(0)] 
		[RED("muzzleOffset")] 
		public Vector4 MuzzleOffset
		{
			get => GetProperty(ref _muzzleOffset);
			set => SetProperty(ref _muzzleOffset, value);
		}

		public AnimFeature_MuzzleData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
