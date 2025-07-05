using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMountedObjectInfo : ISerializable
	{
		[Ordinal(0)] 
		[RED("isFirst")] 
		public CBool IsFirst
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("ref")] 
		public gameEntityReference Ref
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("onMount")] 
		public CBool OnMount
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("role")] 
		public CEnum<gameMountingSlotRole> Role
		{
			get => GetPropertyValue<CEnum<gameMountingSlotRole>>();
			set => SetPropertyValue<CEnum<gameMountingSlotRole>>(value);
		}

		public questMountedObjectInfo()
		{
			Ref = new gameEntityReference { Names = new() };
			OnMount = true;
			Role = Enums.gameMountingSlotRole.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
