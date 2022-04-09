using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MapMenuUserData : IScriptable
	{
		[Ordinal(0)] 
		[RED("moveTo")] 
		public Vector3 MoveTo
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public MapMenuUserData()
		{
			MoveTo = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
