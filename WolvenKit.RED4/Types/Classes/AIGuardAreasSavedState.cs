using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIGuardAreasSavedState : ISerializable
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CArray<AIGuardAreaSavedData> Data
		{
			get => GetPropertyValue<CArray<AIGuardAreaSavedData>>();
			set => SetPropertyValue<CArray<AIGuardAreaSavedData>>(value);
		}

		[Ordinal(1)] 
		[RED("cleared")] 
		public CArray<entEntityID> Cleared
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		public AIGuardAreasSavedState()
		{
			Data = new();
			Cleared = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
