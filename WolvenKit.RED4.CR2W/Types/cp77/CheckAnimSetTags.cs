using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckAnimSetTags : AIbehaviorconditionScript
	{
		private CArray<CName> _animsetTagToCompare;

		[Ordinal(0)] 
		[RED("animsetTagToCompare")] 
		public CArray<CName> AnimsetTagToCompare
		{
			get => GetProperty(ref _animsetTagToCompare);
			set => SetProperty(ref _animsetTagToCompare, value);
		}

		public CheckAnimSetTags(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
