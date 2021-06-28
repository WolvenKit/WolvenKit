using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class moveEnteredSplineEvent : redEvent
	{
		private CBool _useDoors;

		[Ordinal(0)] 
		[RED("useDoors")] 
		public CBool UseDoors
		{
			get => GetProperty(ref _useDoors);
			set => SetProperty(ref _useDoors, value);
		}

		public moveEnteredSplineEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
