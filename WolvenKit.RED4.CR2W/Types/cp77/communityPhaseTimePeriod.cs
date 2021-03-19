using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communityPhaseTimePeriod : communityTimePeriod
	{
		private CUInt16 _quantity;
		private CArray<CName> _markings;
		private CArray<NodeRef> _spotNodeRefs;
		private CArray<gameSpotSequenceCategory> _categories;
		private CBool _isSequence;

		[Ordinal(1)] 
		[RED("quantity")] 
		public CUInt16 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		[Ordinal(2)] 
		[RED("markings")] 
		public CArray<CName> Markings
		{
			get => GetProperty(ref _markings);
			set => SetProperty(ref _markings, value);
		}

		[Ordinal(3)] 
		[RED("spotNodeRefs")] 
		public CArray<NodeRef> SpotNodeRefs
		{
			get => GetProperty(ref _spotNodeRefs);
			set => SetProperty(ref _spotNodeRefs, value);
		}

		[Ordinal(4)] 
		[RED("categories")] 
		public CArray<gameSpotSequenceCategory> Categories
		{
			get => GetProperty(ref _categories);
			set => SetProperty(ref _categories, value);
		}

		[Ordinal(5)] 
		[RED("isSequence")] 
		public CBool IsSequence
		{
			get => GetProperty(ref _isSequence);
			set => SetProperty(ref _isSequence, value);
		}

		public communityPhaseTimePeriod(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
