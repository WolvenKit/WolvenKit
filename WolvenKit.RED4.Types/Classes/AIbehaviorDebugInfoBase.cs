using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorDebugInfoBase : ISerializable
	{
		[Ordinal(0)] 
		[RED("caption")] 
		public CString Caption
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public AIbehaviorDebugInfoBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
