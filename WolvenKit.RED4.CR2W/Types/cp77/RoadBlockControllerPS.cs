using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RoadBlockControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _isBlocking;
		private CBool _negateAnimState;
		private TweakDBID _nameForBlocking;
		private TweakDBID _nameForUnblocking;

		[Ordinal(103)] 
		[RED("isBlocking")] 
		public CBool IsBlocking
		{
			get => GetProperty(ref _isBlocking);
			set => SetProperty(ref _isBlocking, value);
		}

		[Ordinal(104)] 
		[RED("negateAnimState")] 
		public CBool NegateAnimState
		{
			get => GetProperty(ref _negateAnimState);
			set => SetProperty(ref _negateAnimState, value);
		}

		[Ordinal(105)] 
		[RED("nameForBlocking")] 
		public TweakDBID NameForBlocking
		{
			get => GetProperty(ref _nameForBlocking);
			set => SetProperty(ref _nameForBlocking, value);
		}

		[Ordinal(106)] 
		[RED("nameForUnblocking")] 
		public TweakDBID NameForUnblocking
		{
			get => GetProperty(ref _nameForUnblocking);
			set => SetProperty(ref _nameForUnblocking, value);
		}

		public RoadBlockControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
