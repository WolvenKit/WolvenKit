using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Ladder : animAnimFeature
	{
		private CInt32 _state;
		private CInt32 _transitionType;
		private CFloat _distanceFromTop;
		private CBool _entryFromRight;

		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("transitionType")] 
		public CInt32 TransitionType
		{
			get => GetProperty(ref _transitionType);
			set => SetProperty(ref _transitionType, value);
		}

		[Ordinal(2)] 
		[RED("distanceFromTop")] 
		public CFloat DistanceFromTop
		{
			get => GetProperty(ref _distanceFromTop);
			set => SetProperty(ref _distanceFromTop, value);
		}

		[Ordinal(3)] 
		[RED("entryFromRight")] 
		public CBool EntryFromRight
		{
			get => GetProperty(ref _entryFromRight);
			set => SetProperty(ref _entryFromRight, value);
		}

		public animAnimFeature_Ladder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
