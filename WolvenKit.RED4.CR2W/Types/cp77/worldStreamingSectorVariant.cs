using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStreamingSectorVariant : CVariable
	{
		private NodeRef _nodeRef;
		private CUInt32 _variantId;
		private CUInt32 _parentVariantID;
		private CName _name;
		private CUInt32 _rangeIndex;
		private CBool _enabledByDefault;

		[Ordinal(0)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		[Ordinal(1)] 
		[RED("variantId")] 
		public CUInt32 VariantId
		{
			get => GetProperty(ref _variantId);
			set => SetProperty(ref _variantId, value);
		}

		[Ordinal(2)] 
		[RED("parentVariantID")] 
		public CUInt32 ParentVariantID
		{
			get => GetProperty(ref _parentVariantID);
			set => SetProperty(ref _parentVariantID, value);
		}

		[Ordinal(3)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(4)] 
		[RED("rangeIndex")] 
		public CUInt32 RangeIndex
		{
			get => GetProperty(ref _rangeIndex);
			set => SetProperty(ref _rangeIndex, value);
		}

		[Ordinal(5)] 
		[RED("enabledByDefault")] 
		public CBool EnabledByDefault
		{
			get => GetProperty(ref _enabledByDefault);
			set => SetProperty(ref _enabledByDefault, value);
		}

		public worldStreamingSectorVariant(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
