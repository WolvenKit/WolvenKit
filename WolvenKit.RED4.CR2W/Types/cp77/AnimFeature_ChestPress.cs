using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_ChestPress : animAnimFeature
	{
		private CBool _lifting;
		private CBool _kill;

		[Ordinal(0)] 
		[RED("lifting")] 
		public CBool Lifting
		{
			get => GetProperty(ref _lifting);
			set => SetProperty(ref _lifting, value);
		}

		[Ordinal(1)] 
		[RED("kill")] 
		public CBool Kill
		{
			get => GetProperty(ref _kill);
			set => SetProperty(ref _kill, value);
		}

		public AnimFeature_ChestPress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
