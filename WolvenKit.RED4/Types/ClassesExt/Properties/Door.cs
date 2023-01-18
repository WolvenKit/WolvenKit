namespace WolvenKit.RED4.Types
{
    public partial class Door
    {
        [OrdinalOverride(Before = 131)]
        [RED("doorType")]
        public CEnum<Enums.EDoorType> DoorType
        {
            get => GetPropertyValue<CEnum<Enums.EDoorType>>();
            set => SetPropertyValue<CEnum<Enums.EDoorType>>(value);
        }

        [OrdinalOverride(Before = 131)]
        [RED("initialStatus")]
        public CEnum<Enums.EDoorStatus> InitialStatus
        {
            get => GetPropertyValue<CEnum<Enums.EDoorStatus>>();
            set => SetPropertyValue<CEnum<Enums.EDoorStatus>>(value);
        }

        [OrdinalOverride(Before = 131)]
        [RED("canPlayerToggleLockState")]
        public CBool CanPlayerToggleLockState
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        [OrdinalOverride(Before = 131)]
        [RED("isLockable")]
        public CBool IsLockable
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        [OrdinalOverride(Before = 131)]
        [RED("isSealable")]
        public CBool IsSealable
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        [RED("doorStateOperations")]
        public CHandle<DoorStateOperations> DoorStateOperations
        {
            get => GetPropertyValue<CHandle<DoorStateOperations>>();
            set => SetPropertyValue<CHandle<DoorStateOperations>>(value);
        }
    }
}
