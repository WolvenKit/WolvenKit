using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerSetAttachment_ToWorld : questIEntityManagerSetAttachment_NodeSubType
	{
		private NodeRef _attachmentRef;
		private CEnum<questAttachmentOffsetMode> _offsetMode;
		private Vector3 _customOffsetPos;
		private Quaternion _customOffsetRot;

		[Ordinal(0)] 
		[RED("attachmentRef")] 
		public NodeRef AttachmentRef
		{
			get => GetProperty(ref _attachmentRef);
			set => SetProperty(ref _attachmentRef, value);
		}

		[Ordinal(1)] 
		[RED("offsetMode")] 
		public CEnum<questAttachmentOffsetMode> OffsetMode
		{
			get => GetProperty(ref _offsetMode);
			set => SetProperty(ref _offsetMode, value);
		}

		[Ordinal(2)] 
		[RED("customOffsetPos")] 
		public Vector3 CustomOffsetPos
		{
			get => GetProperty(ref _customOffsetPos);
			set => SetProperty(ref _customOffsetPos, value);
		}

		[Ordinal(3)] 
		[RED("customOffsetRot")] 
		public Quaternion CustomOffsetRot
		{
			get => GetProperty(ref _customOffsetRot);
			set => SetProperty(ref _customOffsetRot, value);
		}

		public questEntityManagerSetAttachment_ToWorld(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
