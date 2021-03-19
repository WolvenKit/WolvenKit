using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayedJournalUpdate : redEvent
	{
		private CBool _newMessageSpawned;

		[Ordinal(0)] 
		[RED("newMessageSpawned")] 
		public CBool NewMessageSpawned
		{
			get => GetProperty(ref _newMessageSpawned);
			set => SetProperty(ref _newMessageSpawned, value);
		}

		public DelayedJournalUpdate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
