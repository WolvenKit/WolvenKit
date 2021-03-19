using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNode_ : ISerializable
	{
		private CBool _isVisibleInGame;
		private CBool _isHostOnly;

		[Ordinal(2)] 
		[RED("isVisibleInGame")] 
		public CBool IsVisibleInGame
		{
			get => GetProperty(ref _isVisibleInGame);
			set => SetProperty(ref _isVisibleInGame, value);
		}

		[Ordinal(3)] 
		[RED("isHostOnly")] 
		public CBool IsHostOnly
		{
			get => GetProperty(ref _isHostOnly);
			set => SetProperty(ref _isHostOnly, value);
		}

		public worldNode_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
