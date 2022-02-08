using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class moveStrafingTarget : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("object")] 
		public CWeakHandle<gameObject> Object
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public moveStrafingTarget()
		{
			Position = new() { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity };
		}
	}
}
