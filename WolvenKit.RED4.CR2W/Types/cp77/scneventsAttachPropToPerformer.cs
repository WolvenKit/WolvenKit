using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsAttachPropToPerformer : scnSceneEvent
	{
		private scnPropId _propId;
		private scnPerformerId _performerId;
		private CName _slot;
		private CEnum<scnOffsetMode> _offsetMode;
		private Vector3 _customOffsetPos;
		private Quaternion _customOffsetRot;

		[Ordinal(6)] 
		[RED("propId")] 
		public scnPropId PropId
		{
			get => GetProperty(ref _propId);
			set => SetProperty(ref _propId, value);
		}

		[Ordinal(7)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetProperty(ref _performerId);
			set => SetProperty(ref _performerId, value);
		}

		[Ordinal(8)] 
		[RED("slot")] 
		public CName Slot
		{
			get => GetProperty(ref _slot);
			set => SetProperty(ref _slot, value);
		}

		[Ordinal(9)] 
		[RED("offsetMode")] 
		public CEnum<scnOffsetMode> OffsetMode
		{
			get => GetProperty(ref _offsetMode);
			set => SetProperty(ref _offsetMode, value);
		}

		[Ordinal(10)] 
		[RED("customOffsetPos")] 
		public Vector3 CustomOffsetPos
		{
			get => GetProperty(ref _customOffsetPos);
			set => SetProperty(ref _customOffsetPos, value);
		}

		[Ordinal(11)] 
		[RED("customOffsetRot")] 
		public Quaternion CustomOffsetRot
		{
			get => GetProperty(ref _customOffsetRot);
			set => SetProperty(ref _customOffsetRot, value);
		}

		public scneventsAttachPropToPerformer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
