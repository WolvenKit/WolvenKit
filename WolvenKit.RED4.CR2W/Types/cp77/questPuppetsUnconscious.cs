using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPuppetsUnconscious : questPuppetsEffector
	{
		private CBool _setUnconscious;

		[Ordinal(0)] 
		[RED("setUnconscious")] 
		public CBool SetUnconscious
		{
			get => GetProperty(ref _setUnconscious);
			set => SetProperty(ref _setUnconscious, value);
		}

		public questPuppetsUnconscious(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
