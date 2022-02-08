using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Activator : InteractiveMasterDevice
	{
		[Ordinal(97)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SimpleDevice> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_SimpleDevice>>();
			set => SetPropertyValue<CHandle<AnimFeature_SimpleDevice>>(value);
		}

		[Ordinal(98)] 
		[RED("hitCount")] 
		public CInt32 HitCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(99)] 
		[RED("meshComponent")] 
		public CHandle<entMeshComponent> MeshComponent
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(100)] 
		[RED("meshAppearence")] 
		public CName MeshAppearence
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(101)] 
		[RED("meshAppearenceBreaking")] 
		public CName MeshAppearenceBreaking
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(102)] 
		[RED("meshAppearenceBroken")] 
		public CName MeshAppearenceBroken
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(103)] 
		[RED("defaultDelay")] 
		public CFloat DefaultDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(104)] 
		[RED("yellowDelay")] 
		public CFloat YellowDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(105)] 
		[RED("redDelay")] 
		public CFloat RedDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public Activator()
		{
			ControllerTypeName = "ActivatorController";
			MeshAppearence = "default";
			MeshAppearenceBreaking = "Yellow";
			MeshAppearenceBroken = "red";
			DefaultDelay = 2.980000F;
			YellowDelay = 1.680000F;
			RedDelay = 4.030000F;
		}
	}
}
