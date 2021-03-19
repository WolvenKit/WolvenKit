using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkInputIconMappingJSON : CVariable
	{
		private CName _id;
		private CName _part;
		private CBool _hold;

		[Ordinal(0)] 
		[RED("id")] 
		public CName Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("part")] 
		public CName Part
		{
			get => GetProperty(ref _part);
			set => SetProperty(ref _part, value);
		}

		[Ordinal(2)] 
		[RED("hold")] 
		public CBool Hold
		{
			get => GetProperty(ref _hold);
			set => SetProperty(ref _hold, value);
		}

		public inkInputIconMappingJSON(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
