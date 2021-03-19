using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AnimDatabase : animAnimNode_SkPhaseWithDurationAnim
	{
		private animAnimDatabaseCollectionEntry _animDataBase;
		private CArray<animIntLink> _inputLinks;

		[Ordinal(32)] 
		[RED("animDataBase")] 
		public animAnimDatabaseCollectionEntry AnimDataBase
		{
			get => GetProperty(ref _animDataBase);
			set => SetProperty(ref _animDataBase, value);
		}

		[Ordinal(33)] 
		[RED("inputLinks")] 
		public CArray<animIntLink> InputLinks
		{
			get => GetProperty(ref _inputLinks);
			set => SetProperty(ref _inputLinks, value);
		}

		public animAnimNode_AnimDatabase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
