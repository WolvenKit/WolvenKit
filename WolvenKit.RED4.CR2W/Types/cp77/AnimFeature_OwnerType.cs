using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_OwnerType : animAnimFeature
	{
		private CInt32 _ownerEnum;

		[Ordinal(0)] 
		[RED("ownerEnum")] 
		public CInt32 OwnerEnum
		{
			get => GetProperty(ref _ownerEnum);
			set => SetProperty(ref _ownerEnum, value);
		}

		public AnimFeature_OwnerType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
