using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Mounting : animAnimFeature
	{
		private CInt32 _mountingState;
		private CFloat _parentSpeed;

		[Ordinal(0)] 
		[RED("mountingState")] 
		public CInt32 MountingState
		{
			get => GetProperty(ref _mountingState);
			set => SetProperty(ref _mountingState, value);
		}

		[Ordinal(1)] 
		[RED("parentSpeed")] 
		public CFloat ParentSpeed
		{
			get => GetProperty(ref _parentSpeed);
			set => SetProperty(ref _parentSpeed, value);
		}

		public AnimFeature_Mounting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
