using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameImpostorComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("isCharacterReplica")] 
		public CBool IsCharacterReplica
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("addHead")] 
		public CBool AddHead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("ignorePlayerHeadSlot")] 
		public CBool IgnorePlayerHeadSlot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("slotIDsToOmit")] 
		public CArray<TweakDBID> SlotIDsToOmit
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		public gameImpostorComponent()
		{
			Name = "Component";
			IsCharacterReplica = true;
			AddHead = true;
			IgnorePlayerHeadSlot = true;
			SlotIDsToOmit = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
