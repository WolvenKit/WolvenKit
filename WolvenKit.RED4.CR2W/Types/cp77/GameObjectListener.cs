using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameObjectListener : IScriptable
	{
		private CHandle<gamePrereqState> _prereqOwner;
		private CBool _e3HackBlock;

		[Ordinal(0)] 
		[RED("prereqOwner")] 
		public CHandle<gamePrereqState> PrereqOwner
		{
			get => GetProperty(ref _prereqOwner);
			set => SetProperty(ref _prereqOwner, value);
		}

		[Ordinal(1)] 
		[RED("e3HackBlock")] 
		public CBool E3HackBlock
		{
			get => GetProperty(ref _e3HackBlock);
			set => SetProperty(ref _e3HackBlock, value);
		}

		public GameObjectListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
