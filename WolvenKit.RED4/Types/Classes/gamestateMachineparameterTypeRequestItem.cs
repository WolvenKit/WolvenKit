using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineparameterTypeRequestItem : IScriptable
	{
		[Ordinal(0)] 
		[RED("requests")] 
		public CArray<gameEquipParam> Requests
		{
			get => GetPropertyValue<CArray<gameEquipParam>>();
			set => SetPropertyValue<CArray<gameEquipParam>>(value);
		}

		public gamestateMachineparameterTypeRequestItem()
		{
			Requests = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
