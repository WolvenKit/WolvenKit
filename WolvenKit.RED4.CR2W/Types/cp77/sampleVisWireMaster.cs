using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleVisWireMaster : gameObject
	{
		private CArray<NodeRef> _dependableEntities;
		private CBool _inFocus;
		private CBool _found;
		private CBool _lookedAt;

		[Ordinal(40)] 
		[RED("dependableEntities")] 
		public CArray<NodeRef> DependableEntities
		{
			get => GetProperty(ref _dependableEntities);
			set => SetProperty(ref _dependableEntities, value);
		}

		[Ordinal(41)] 
		[RED("inFocus")] 
		public CBool InFocus
		{
			get => GetProperty(ref _inFocus);
			set => SetProperty(ref _inFocus, value);
		}

		[Ordinal(42)] 
		[RED("found")] 
		public CBool Found
		{
			get => GetProperty(ref _found);
			set => SetProperty(ref _found, value);
		}

		[Ordinal(43)] 
		[RED("lookedAt")] 
		public CBool LookedAt
		{
			get => GetProperty(ref _lookedAt);
			set => SetProperty(ref _lookedAt, value);
		}

		public sampleVisWireMaster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
