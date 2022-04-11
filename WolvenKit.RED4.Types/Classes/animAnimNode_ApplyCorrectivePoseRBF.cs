using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_ApplyCorrectivePoseRBF : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("rbfCoefficient")] 
		public CFloat RbfCoefficient
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("rbfPowValue")] 
		public CFloat RbfPowValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("correctiveFrame")] 
		public CFloat CorrectiveFrame
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("correctives")] 
		public CArray<animCorrectivePoseEntry> Correctives
		{
			get => GetPropertyValue<CArray<animCorrectivePoseEntry>>();
			set => SetPropertyValue<CArray<animCorrectivePoseEntry>>(value);
		}

		public animAnimNode_ApplyCorrectivePoseRBF()
		{
			Id = 4294967295;
			InputLink = new();
			RbfCoefficient = 3.500000F;
			RbfPowValue = 20.000000F;
			CorrectiveFrame = 0.033330F;
			Correctives = new();
		}
	}
}
