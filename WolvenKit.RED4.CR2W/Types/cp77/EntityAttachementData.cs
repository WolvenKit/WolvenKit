using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EntityAttachementData : CVariable
	{
		private CName _slotName;
		private CName _slotComponentName;
		private NodeRef _nodeRef;
		private CName _attachementComponentName;
		private entEntityID _ownerID;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(1)] 
		[RED("slotComponentName")] 
		public CName SlotComponentName
		{
			get => GetProperty(ref _slotComponentName);
			set => SetProperty(ref _slotComponentName, value);
		}

		[Ordinal(2)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		[Ordinal(3)] 
		[RED("attachementComponentName")] 
		public CName AttachementComponentName
		{
			get => GetProperty(ref _attachementComponentName);
			set => SetProperty(ref _attachementComponentName, value);
		}

		[Ordinal(4)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		public EntityAttachementData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
