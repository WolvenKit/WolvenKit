using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPrereq_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("isObjectPlayer")] 
		public CBool IsObjectPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("prereq")] 
		public CHandle<gameIPrereq> Prereq
		{
			get => GetPropertyValue<CHandle<gameIPrereq>>();
			set => SetPropertyValue<CHandle<gameIPrereq>>(value);
		}

		public questPrereq_ConditionType()
		{
			ObjectRef = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
