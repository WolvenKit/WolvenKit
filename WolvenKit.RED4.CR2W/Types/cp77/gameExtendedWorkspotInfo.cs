using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameExtendedWorkspotInfo : IScriptable
	{
		private CBool _isActive;
		private CBool _entering;
		private CBool _exiting;
		private CBool _playingSyncAnim;
		private CBool _inReaction;
		private CBool _inMotion;

		[Ordinal(0)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(1)] 
		[RED("entering")] 
		public CBool Entering
		{
			get => GetProperty(ref _entering);
			set => SetProperty(ref _entering, value);
		}

		[Ordinal(2)] 
		[RED("exiting")] 
		public CBool Exiting
		{
			get => GetProperty(ref _exiting);
			set => SetProperty(ref _exiting, value);
		}

		[Ordinal(3)] 
		[RED("playingSyncAnim")] 
		public CBool PlayingSyncAnim
		{
			get => GetProperty(ref _playingSyncAnim);
			set => SetProperty(ref _playingSyncAnim, value);
		}

		[Ordinal(4)] 
		[RED("inReaction")] 
		public CBool InReaction
		{
			get => GetProperty(ref _inReaction);
			set => SetProperty(ref _inReaction, value);
		}

		[Ordinal(5)] 
		[RED("inMotion")] 
		public CBool InMotion
		{
			get => GetProperty(ref _inMotion);
			set => SetProperty(ref _inMotion, value);
		}

		public gameExtendedWorkspotInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
