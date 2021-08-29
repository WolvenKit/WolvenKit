using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiUnlockableProgram : RedBaseClass
	{
		private CName _name;
		private CName _note;
		private CBool _isFulfilled;
		private TweakDBID _programTweakID;
		private TweakDBID _iconTweakID;
		private CBool _hidden;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("note")] 
		public CName Note
		{
			get => GetProperty(ref _note);
			set => SetProperty(ref _note, value);
		}

		[Ordinal(2)] 
		[RED("isFulfilled")] 
		public CBool IsFulfilled
		{
			get => GetProperty(ref _isFulfilled);
			set => SetProperty(ref _isFulfilled, value);
		}

		[Ordinal(3)] 
		[RED("programTweakID")] 
		public TweakDBID ProgramTweakID
		{
			get => GetProperty(ref _programTweakID);
			set => SetProperty(ref _programTweakID, value);
		}

		[Ordinal(4)] 
		[RED("iconTweakID")] 
		public TweakDBID IconTweakID
		{
			get => GetProperty(ref _iconTweakID);
			set => SetProperty(ref _iconTweakID, value);
		}

		[Ordinal(5)] 
		[RED("hidden")] 
		public CBool Hidden
		{
			get => GetProperty(ref _hidden);
			set => SetProperty(ref _hidden, value);
		}
	}
}
