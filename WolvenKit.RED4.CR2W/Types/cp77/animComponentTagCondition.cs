using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animComponentTagCondition : animIStaticCondition
	{
		private CName _animTag;

		[Ordinal(0)] 
		[RED("animTag")] 
		public CName AnimTag
		{
			get => GetProperty(ref _animTag);
			set => SetProperty(ref _animTag, value);
		}

		public animComponentTagCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
