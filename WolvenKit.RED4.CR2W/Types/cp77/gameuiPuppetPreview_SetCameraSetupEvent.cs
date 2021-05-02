using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPuppetPreview_SetCameraSetupEvent : redEvent
	{
		private CUInt32 _setupIndex;
		private CName _slotName;
		private CBool _delayed;

		[Ordinal(0)] 
		[RED("setupIndex")] 
		public CUInt32 SetupIndex
		{
			get => GetProperty(ref _setupIndex);
			set => SetProperty(ref _setupIndex, value);
		}

		[Ordinal(1)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(2)] 
		[RED("delayed")] 
		public CBool Delayed
		{
			get => GetProperty(ref _delayed);
			set => SetProperty(ref _delayed, value);
		}

		public gameuiPuppetPreview_SetCameraSetupEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
