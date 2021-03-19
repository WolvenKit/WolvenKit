using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animConditionalSegmentCondition : CVariable
	{
		private CInt32 _lod;
		private CName _group;
		private CName _name;
		private CBool _animFeatureValue;

		[Ordinal(0)] 
		[RED("lod")] 
		public CInt32 Lod
		{
			get => GetProperty(ref _lod);
			set => SetProperty(ref _lod, value);
		}

		[Ordinal(1)] 
		[RED("group")] 
		public CName Group
		{
			get => GetProperty(ref _group);
			set => SetProperty(ref _group, value);
		}

		[Ordinal(2)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(3)] 
		[RED("animFeatureValue")] 
		public CBool AnimFeatureValue
		{
			get => GetProperty(ref _animFeatureValue);
			set => SetProperty(ref _animFeatureValue, value);
		}

		public animConditionalSegmentCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
