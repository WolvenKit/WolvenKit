using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class animIMotionTableProvider : ISerializable
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("parentId")] 
		public CInt32 ParentId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<animMotionTableType> Type
		{
			get => GetPropertyValue<CEnum<animMotionTableType>>();
			set => SetPropertyValue<CEnum<animMotionTableType>>(value);
		}

		[Ordinal(3)] 
		[RED("action")] 
		public CEnum<animMotionTableAction> Action
		{
			get => GetPropertyValue<CEnum<animMotionTableAction>>();
			set => SetPropertyValue<CEnum<animMotionTableAction>>(value);
		}

		[Ordinal(4)] 
		[RED("parentStaticSwitchBranch")] 
		public CEnum<animParentStaticSwitchBranch> ParentStaticSwitchBranch
		{
			get => GetPropertyValue<CEnum<animParentStaticSwitchBranch>>();
			set => SetPropertyValue<CEnum<animParentStaticSwitchBranch>>(value);
		}

		public animIMotionTableProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
