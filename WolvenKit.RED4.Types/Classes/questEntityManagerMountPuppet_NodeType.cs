using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEntityManagerMountPuppet_NodeType : questIEntityManager_NodeType
	{
		[Ordinal(0)] 
		[RED("parentRef")] 
		public gameEntityReference ParentRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("childRef")] 
		public gameEntityReference ChildRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(2)] 
		[RED("isParentPlayer")] 
		public CBool IsParentPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("assign")] 
		public CBool Assign
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("forcedCarryStyle")] 
		public CEnum<gamePSMBodyCarryingStyle> ForcedCarryStyle
		{
			get => GetPropertyValue<CEnum<gamePSMBodyCarryingStyle>>();
			set => SetPropertyValue<CEnum<gamePSMBodyCarryingStyle>>(value);
		}

		[Ordinal(7)] 
		[RED("removePitchRollRotation")] 
		public CBool RemovePitchRollRotation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questEntityManagerMountPuppet_NodeType()
		{
			ParentRef = new() { Names = new() };
			ChildRef = new() { Names = new() };
			Assign = true;
			IsInstant = true;
			ForcedCarryStyle = Enums.gamePSMBodyCarryingStyle.Friendly;
			RemovePitchRollRotation = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
