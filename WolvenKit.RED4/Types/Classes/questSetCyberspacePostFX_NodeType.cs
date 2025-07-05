using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetCyberspacePostFX_NodeType : questIRenderFxManagerNodeType
	{
		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("fullScreen")] 
		public CBool FullScreen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("vfx")] 
		public CBool Vfx
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("initialDatamosh")] 
		public CFloat InitialDatamosh
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("targetDatamosh")] 
		public CFloat TargetDatamosh
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("initialTreshold")] 
		public CFloat InitialTreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("targetTreshold")] 
		public CFloat TargetTreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("timeBlend")] 
		public CFloat TimeBlend
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public questSetCyberspacePostFX_NodeType()
		{
			Enabled = true;
			FullScreen = true;
			TargetDatamosh = 1.000000F;
			TargetTreshold = 0.300000F;
			TimeBlend = 3.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
