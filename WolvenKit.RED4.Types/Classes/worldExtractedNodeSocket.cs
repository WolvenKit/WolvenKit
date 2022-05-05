using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldExtractedNodeSocket : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("displayName")] 
		public CName DisplayName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(4)] 
		[RED("direction")] 
		public Vector3 Direction
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<worldNodeSocketType> Type
		{
			get => GetPropertyValue<CEnum<worldNodeSocketType>>();
			set => SetPropertyValue<CEnum<worldNodeSocketType>>(value);
		}

		[Ordinal(6)] 
		[RED("isSnapped")] 
		public CBool IsSnapped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public worldExtractedNodeSocket()
		{
			Position = new();
			Rotation = new() { R = 1.000000F };
			Direction = new();
			Color = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
