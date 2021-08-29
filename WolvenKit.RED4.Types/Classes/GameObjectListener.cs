using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameObjectListener : IScriptable
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
	}
}
