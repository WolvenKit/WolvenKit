using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_SmartObject : animAnimFeature
	{
		private CInt32 _state;
		private CName _privateAnimationName;

		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("privateAnimationName")] 
		public CName PrivateAnimationName
		{
			get => GetProperty(ref _privateAnimationName);
			set => SetProperty(ref _privateAnimationName, value);
		}

		public animAnimFeature_SmartObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
