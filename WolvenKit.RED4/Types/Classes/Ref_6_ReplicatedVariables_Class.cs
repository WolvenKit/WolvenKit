using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_6_ReplicatedVariables_Class : IScriptable
	{
		[Ordinal(0)] 
		[RED("thisIsReplicatedFieldInClass")] 
		public CInt32 ThisIsReplicatedFieldInClass
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public Ref_6_ReplicatedVariables_Class()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
