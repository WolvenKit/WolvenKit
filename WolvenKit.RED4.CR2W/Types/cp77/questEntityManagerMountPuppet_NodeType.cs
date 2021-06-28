using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerMountPuppet_NodeType : questIEntityManager_NodeType
	{
		private gameEntityReference _parentRef;
		private gameEntityReference _childRef;
		private CBool _isParentPlayer;
		private CName _slotName;
		private CBool _assign;
		private CBool _isInstant;
		private CEnum<gamePSMBodyCarryingStyle> _forcedCarryStyle;
		private CBool _removePitchRollRotation;

		[Ordinal(0)] 
		[RED("parentRef")] 
		public gameEntityReference ParentRef
		{
			get => GetProperty(ref _parentRef);
			set => SetProperty(ref _parentRef, value);
		}

		[Ordinal(1)] 
		[RED("childRef")] 
		public gameEntityReference ChildRef
		{
			get => GetProperty(ref _childRef);
			set => SetProperty(ref _childRef, value);
		}

		[Ordinal(2)] 
		[RED("isParentPlayer")] 
		public CBool IsParentPlayer
		{
			get => GetProperty(ref _isParentPlayer);
			set => SetProperty(ref _isParentPlayer, value);
		}

		[Ordinal(3)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(4)] 
		[RED("assign")] 
		public CBool Assign
		{
			get => GetProperty(ref _assign);
			set => SetProperty(ref _assign, value);
		}

		[Ordinal(5)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get => GetProperty(ref _isInstant);
			set => SetProperty(ref _isInstant, value);
		}

		[Ordinal(6)] 
		[RED("forcedCarryStyle")] 
		public CEnum<gamePSMBodyCarryingStyle> ForcedCarryStyle
		{
			get => GetProperty(ref _forcedCarryStyle);
			set => SetProperty(ref _forcedCarryStyle, value);
		}

		[Ordinal(7)] 
		[RED("removePitchRollRotation")] 
		public CBool RemovePitchRollRotation
		{
			get => GetProperty(ref _removePitchRollRotation);
			set => SetProperty(ref _removePitchRollRotation, value);
		}

		public questEntityManagerMountPuppet_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
