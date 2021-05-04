using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TCSTakeOverControlActivate : redEvent
	{
		private CBool _isQuickhack;

		[Ordinal(0)] 
		[RED("IsQuickhack")] 
		public CBool IsQuickhack
		{
			get => GetProperty(ref _isQuickhack);
			set => SetProperty(ref _isQuickhack, value);
		}

		public TCSTakeOverControlActivate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
