using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSetExclusiveFocusClueEntityEvent : redEvent
	{
		private CBool _isSetExclusive;

		[Ordinal(0)] 
		[RED("isSetExclusive")] 
		public CBool IsSetExclusive
		{
			get => GetProperty(ref _isSetExclusive);
			set => SetProperty(ref _isSetExclusive, value);
		}

		public gameSetExclusiveFocusClueEntityEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
