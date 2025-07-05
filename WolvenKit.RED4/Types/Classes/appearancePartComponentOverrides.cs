using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class appearancePartComponentOverrides : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("chunkMask")] 
		public CUInt64 ChunkMask
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(3)] 
		[RED("useCustomTransform")] 
		public CBool UseCustomTransform
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("initialTransform")] 
		public Transform InitialTransform
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(5)] 
		[RED("visualScale")] 
		public Vector3 VisualScale
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(6)] 
		[RED("acceptDismemberment")] 
		public CBool AcceptDismemberment
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public appearancePartComponentOverrides()
		{
			MeshAppearance = "default";
			ChunkMask = long.MaxValue;
			InitialTransform = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };
			VisualScale = new Vector3();
			AcceptDismemberment = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
