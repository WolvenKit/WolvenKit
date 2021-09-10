using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineeventImpulse : gamestateMachineeventBaseEvent
	{
		[Ordinal(1)] 
		[RED("impulse")] 
		public Vector4 Impulse
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gamestateMachineeventImpulse()
		{
			Impulse = new();
		}
	}
}
