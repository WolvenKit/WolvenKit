using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_FacialReaction : animAnimFeature
	{
		private CInt32 _category;
		private CInt32 _idle;

		[Ordinal(0)] 
		[RED("category")] 
		public CInt32 Category
		{
			get => GetProperty(ref _category);
			set => SetProperty(ref _category, value);
		}

		[Ordinal(1)] 
		[RED("idle")] 
		public CInt32 Idle
		{
			get => GetProperty(ref _idle);
			set => SetProperty(ref _idle, value);
		}

		public AnimFeature_FacialReaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
