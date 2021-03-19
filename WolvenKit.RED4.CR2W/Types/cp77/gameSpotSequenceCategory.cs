using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSpotSequenceCategory : CVariable
	{
		private CEnum<gamedataWorkspotCategory> _type;
		private CFloat _probability;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataWorkspotCategory> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("probability")] 
		public CFloat Probability
		{
			get => GetProperty(ref _probability);
			set => SetProperty(ref _probability, value);
		}

		public gameSpotSequenceCategory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
