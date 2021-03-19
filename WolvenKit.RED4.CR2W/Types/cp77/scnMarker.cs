using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnMarker : CVariable
	{
		private CEnum<scnMarkerType> _type;
		private CName _localMarkerId;
		private NodeRef _nodeRef;
		private gameEntityReference _entityRef;
		private CName _slotName;
		private CBool _isMounted;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<scnMarkerType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("localMarkerId")] 
		public CName LocalMarkerId
		{
			get => GetProperty(ref _localMarkerId);
			set => SetProperty(ref _localMarkerId, value);
		}

		[Ordinal(2)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		[Ordinal(3)] 
		[RED("entityRef")] 
		public gameEntityReference EntityRef
		{
			get => GetProperty(ref _entityRef);
			set => SetProperty(ref _entityRef, value);
		}

		[Ordinal(4)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(5)] 
		[RED("isMounted")] 
		public CBool IsMounted
		{
			get => GetProperty(ref _isMounted);
			set => SetProperty(ref _isMounted, value);
		}

		public scnMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
