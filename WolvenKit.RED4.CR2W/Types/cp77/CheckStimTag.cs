using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckStimTag : AIbehaviorconditionScript
	{
		private CArray<CName> _stimTagToCompare;

		[Ordinal(0)] 
		[RED("stimTagToCompare")] 
		public CArray<CName> StimTagToCompare
		{
			get => GetProperty(ref _stimTagToCompare);
			set => SetProperty(ref _stimTagToCompare, value);
		}

		public CheckStimTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
